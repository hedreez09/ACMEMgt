using System;

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

            Object myObject = new object();
            Console.WriteLine($"Object : {myObject.ToString()}");
            Console.WriteLine($"Product : {product.ToString()}");
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