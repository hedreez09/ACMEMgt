﻿using ACME.Common1;
using System;

namespace ACMEMgt
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            
            ProductId = productId;
        }

        
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public Decimal? CurrentPrice { get; set; }

        private string _productName;

        public string ProductName 
        { 
            get 
            {
                return _productName.InsertSpaces();
            }
            set 
            { 
                _productName = value;
            }

        }

        //using expression body
        public override string ToString() => ProductName;


        public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDescription} Status:{EntityState.ToString()}";

        //To validate that the specified field are required and not null
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}