using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
	public class DigitalProductModel : IProductModel 
		// 1. Applying interface to Physical Product Model class
	{   // Note that: interface is higlighted. Use 'CTRL + .' and select implement throw new exception.
		public string Title { get; set; }

		// public bool HasOrderBeenCompleted => throw new NotImplementedException();   
		//3. But by using this we actually don t wan t to break our code in Debugging 
		public bool HasOrderBeenCompleted { get; private set; }  
		// 4. It is better to implement this. Get is read only and set is internal. 

		public int TotalDownloadsleft { get; private set; } = 5;   
		// 5. Adding another property, when it goes to digital products going to limit them certain number maximum of downloads
		public void ShipItem(CustomerModel customer)  
		{
			if (HasOrderBeenCompleted == false)  // 7. Let's make sure the order is not yet been completed 
			{
				Console.WriteLine($"Simulating emailing { Title } to { customer.EmailAddress }");
				// 6. Select this line and add if snippet and change true to HasOrderBeenCompleted
				TotalDownloadsleft -= 1;   
				// 8. subtract 1 form the total 
				if (TotalDownloadsleft < 1)  
					// 9. if total downloads left is less than 1.
				{
					HasOrderBeenCompleted = true;  
					// 10. is it true
					TotalDownloadsleft = 0;   
					// 11. set to zero
				}
			} 
		}
	}
}
