using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class PhysicalProductModel // Physical Product Model
    {
        public string Title { get; set; } // Each one has a title
        public bool HasOrderBeenCompleted { get; private set; } // has bollean Has order been completed

        public void ShipItem(CustomerModel customer) // method called ship Item, that takes in the customer model
        {
            if (HasOrderBeenCompleted == false) // if the order has not been completed than we have the Console Writeline below
            {
                Console.WriteLine($"Simulating shipping { Title } to { customer.FirstName } in { customer.City }"); 
                // simulating shipping this item to this person in this city

                HasOrderBeenCompleted = true;    // than we mark the order complete
            }
        }
    }
}
