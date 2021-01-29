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
            List<PhysicalProductModel> cart = AddSampleData();  // shopping cart
            CustomerModel customer = GetCustomer();             // customer

            foreach (PhysicalProductModel prod in cart)        // loop through every item of the cart, which is the product each individual product ship item
            {
                prod.ShipItem(customer);                       // product pass in the customer object
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

        private static List<PhysicalProductModel> AddSampleData()
        {
            List<PhysicalProductModel> output = new List<PhysicalProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerd Football" });
            output.Add(new PhysicalProductModel { Title = "Joshhortt T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });

            return output;
        }
    }
}
/* OUTPUT
Simulating shipping Nerd Football to Josh in Lagos
Simulating shipping Joshhortt T-Shirt to Josh in Lagos
Simulating shipping Hard Drive to Josh in Lagos
 */