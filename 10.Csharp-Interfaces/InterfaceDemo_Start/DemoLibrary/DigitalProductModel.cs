using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
	public class DigitalProductModel
	{
		public string Title { get; set; }  // 1. Add a title
		public void ShipItem(CustomerModel customer)  // 2. Add Ship Item method
		{
			Console.WriteLine($"Simulating emailing { Title } to { customer.EmailAddress }");  // 3. emailing this item to this Email address
		}
	}
}
