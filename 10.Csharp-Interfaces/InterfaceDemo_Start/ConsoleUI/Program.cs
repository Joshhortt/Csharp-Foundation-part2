// 10. Interfaces in C# . Simple Console Aplication that acts as a point of sale system.

using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData(); 
            CustomerModel customer = GetCustomer();            

            foreach (IProductModel prod in cart)           
            {
                prod.ShipItem(customer);    
                
                if (prod is IDigitalProductModel digital)  
				{
					Console.WriteLine($"For the { digital.Title } you have { digital.TotalDownloadsLeft } downloads left.");
				}
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Josh",
                LastName = "Hortt",
                City = "Lagos",
                EmailAddress = "joshhortt@yahoo.com",
                PhoneNumber = "911-815-877"
            };
        }

        private static List<IProductModel> AddSampleData()  
        {
            List<IProductModel> output = new List<IProductModel>();  

            output.Add(new PhysicalProductModel { Title = "Nerd Football" });
            output.Add(new PhysicalProductModel { Title = "Joshhortt T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
           // output.Add(new DigitalProductModel { Title = "Lesson Source Code" });  // 8. Just comment it to make CourseProductModel work without error.
            output.Add(new CourseProductModel { Title = ".Net Console Aplicatios " });  // 7. Add CourseProductModel output
            return output;
        }
    }
}
/* OUTPUT
Simulating shipping Nerd Football to Josh in Lagos
Simulating shipping Joshhortt T-Shirt to Josh in Lagos
Simulating shipping Hard Drive to Josh in Lagos
Added the .Net Console Aplicatios  course to Josh's account.
 */