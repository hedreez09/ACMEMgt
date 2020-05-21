using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEMgt
{
	public class ProductRepository
	{
		public Product Retrieve(int productId)
		{
			//Create an instance of the product class 
			//pass in the requested Id
			Product product = new Product(productId);

			//Code hat retrieve precise product
			//a populated product
			if (productId == 1)
			{
				product.ProductName = "Samosa";
				product.ProductDescription = "Finger food";
				product.CurrentPrice = 23.34M;			
			}
			return product;
		}

		//Save  the current product
		public bool Save(Product product)
		{
			//code that save passed product

			return true;
		}

	}
}
