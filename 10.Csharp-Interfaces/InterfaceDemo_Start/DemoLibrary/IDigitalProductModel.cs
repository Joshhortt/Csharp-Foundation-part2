using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
	public interface IDigitalProductModel : IProductModel  // 1. The inteface IDigitalProductModel implements the inteface IProductModel
	{
		int TotalDownloadsLeft { get; }   // 2. Says Ia m not removing anything but adding more sff it
	}
}
