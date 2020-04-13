using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEMgt
{
	public class Product
	{
		public string ProductName { get; set; }
		public string Description { get; set; }
		public string CurrentPrice { get; set; }


		//To retrieve one product 
		public Product Retrieve(int productId)
		{
			//code that retrieve the specified product
			return new Product();
		}
		//To retrieve all product
		public List<Product> Retrieve()
		{
			//code that retrieve all product
			return new List<Product>();
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
			if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
			if (string.IsNullOrWhiteSpace(Description)) isValid = false;
			if (string.IsNullOrWhiteSpace(CurrentPrice)) isValid  = false

			return isValid;
		}
	}
}
