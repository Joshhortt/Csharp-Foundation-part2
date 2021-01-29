using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
	public interface IProductModel  // 1.Naming convention for Intefaces is a Capital 'I' in front of the Interface name.
	{
		string Title { get; set; }  // 2. Delete public

		bool HasOrderBeenCompleted { get; }  // 3. Delete public and remove 'private set;'

		void ShipItem(CustomerModel customer);  // 4. Delete public
	}
}
