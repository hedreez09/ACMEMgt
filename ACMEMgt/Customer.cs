﻿using ACME.Common1;
using System.Collections.Generic;

namespace ACMEMgt
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer() : this(0)
        {
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public int CustomerId { get; private set; }
        public List<Address> AddressList { get; set; }
        public string FirstName { get; set; }
        public int CustomerType { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public override string ToString() => FullName;

        public string Log() => $"{CustomerId} : {FullName} Email : {EmailAddress} Status: {EntityState.ToString()}";

        //To validate that the specified field are required and not null
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        //public string Log()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}