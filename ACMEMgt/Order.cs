using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEMgt
{
	public class Order
	{
		public DateTime OrderDate { get; set; }

		//To retrieve one product 
		public OrderDate Retrieve(int productId)
		{
			//code that retrieve the specified product
			return new OrderDate();
		}
		//To retrieve all product
		public List<OrderDate> Retrieve()
		{
			//code that retrieve all product
			return new List<OrderDate>();
		}

		//To Save the current prodcut
		public bool Save()
		{
			//Code that save the defiened product
			return true;
		}

		//To validate that the specified field are required and not null
		public bool Validate()
		{


			return true;
		}
	}
}
