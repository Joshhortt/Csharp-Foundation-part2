using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
	public class DigitalProductModel 
	{   
		public string Title { get; set; }

		public bool HasOrderBeenCompleted { get; private set; }  

		public int TotalDownloadsleft { get; private set; } = 5;   

		public void ShipItem(CustomerModel customer)  
		{
			if (HasOrderBeenCompleted == false)  
			{
				Console.WriteLine($"Simulating emailing { Title } to { customer.EmailAddress }");
				TotalDownloadsleft -= 1;
				if (TotalDownloadsleft < 1)  
				{
					HasOrderBeenCompleted = true; 
					TotalDownloadsleft = 0;   
				}
			} 
		}
	}
}
