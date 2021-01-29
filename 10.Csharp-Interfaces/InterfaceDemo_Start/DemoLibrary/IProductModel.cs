using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{

	// Interface is like a contract
	public interface IProductModel  // 1. Who ever implement me  will have
	{
		string Title { get; set; }  // 2. a title property with get and set, that is a type string 

		bool HasOrderBeenCompleted { get; }  // 3.Has a order been completed property with get and a boolean return value 

		void ShipItem(CustomerModel customer);  // 4. a method called ship item  that takes in a customer model and returns void nothing)
	}
}
