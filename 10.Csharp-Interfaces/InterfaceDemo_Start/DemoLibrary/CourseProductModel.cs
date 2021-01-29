using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
	public class CourseProductModel : IProductModel  // 1. create new class CurseProduct model. Add Interface IProductModel -- > (CTRL + .)
	{
		public string Title { get; set; }  // 2. take implement exceptions out

		public bool HasOrderBeenCompleted { get; private set; }  // 3. take implement exceptions out. Just put the get; private set inside curly braces.

		public void ShipItem(CustomerModel customer)
		{
			if(HasOrderBeenCompleted  == false)  // 4. if NOT (!HasOrderBeenCompleted) or if it's false. -- > easier to read
				Console.WriteLine($"Added the { Title } course to { customer.FirstName }'s account.");  // 5. CW the Title and Customer's First name .
				HasOrderBeenCompleted = true;  // 6. If true than ..
			}
			
		}
	}

