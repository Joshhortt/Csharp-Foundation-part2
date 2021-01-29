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
                
                if (prod is IDigitalProductModel digital)  // 3. If item whis is IDigitalProductModel put that in that digital variable
				{
					Console.WriteLine($"For the { digital.Title } you have { digital.TotalDownloadsLeft } downloads left.");
                    // 4. I have access to the title but also to the downloads left, which is not part of the IProductModel Interface contract
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
            output.Add(new DigitalProductModel { Title = "Lesson Source Code" });  

            return output;
        }
    }
}
/* OUTPUT
Simulating shipping Nerd Football to Josh in Lagos
Simulating shipping Joshhortt T-Shirt to Josh in Lagos
Simulating shipping Hard Drive to Josh in Lagos
Simulating emailing Lesson Source Code to joshhortt@yahoo.com
 */