using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEMgt
{
	 public class OrderItem
	{
		public OrderItem()
		{

		}
		public OrderItem(int orderItemId)
		{
			OrderItemId = orderItemId;
		}
		public int OrderItemId { get; private set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public Decimal? PurchasePrice { get; set; }


		//To retrieve one orderItem 
		public OrderItem Retrieve(int orderItemId)
		{
			//code that retrieve the specified product
			return new OrderItem();
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
			var isValid = true;
			if (Quantity <= 0) isValid = false;
			if (ProductId <= 0) isValid = false;
			if (PurchasePrice == null) isValid= false;

			return isValid;
		}
	}
}
