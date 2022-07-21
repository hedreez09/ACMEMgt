﻿using System;

namespace ACMEMgt
{
    public class Product
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public string ProductName { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public Decimal? CurrentPrice { get; set; }

        //using expression body
        public override string ToString() => ProductName;

        //To validate that the specified field are required and not null
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}