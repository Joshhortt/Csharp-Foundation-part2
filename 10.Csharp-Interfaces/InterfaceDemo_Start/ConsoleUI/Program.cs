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
            List<IProductModel> cart = AddSampleData();  // 1. instead of giving the actual class we give the interface
            CustomerModel customer = GetCustomer();            

            foreach (IProductModel prod in cart)           // 5. Change to interface
            {
                prod.ShipItem(customer);                       
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

        private static List<IProductModel> AddSampleData()  // 2. Change to interface
        {
            List<IProductModel> output = new List<IProductModel>();   // 3. Change to interface

            output.Add(new PhysicalProductModel { Title = "Nerd Football" });
            output.Add(new PhysicalProductModel { Title = "Joshhortt T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "Lesson Source Code" });  // 4. Add a digital product

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