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
		public Order Retrieve(int productId)
		{
			//code that retrieve the specified product
			return new Order();
		}
		//To retrieve all product
		public List<Order> Retrieve()
		{
			//code that retrieve all product
			return new List<Order>();
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
