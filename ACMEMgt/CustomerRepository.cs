﻿using System.Linq;

namespace ACMEMgt
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository(); //a collaborative relations
        }

        public Customer Retrieve(int customerId)
        {
            //Create an instance of the customer class
            //pass in the requested Id
            Customer customer = new Customer(customerId);

            //Code hat retrieve precise customer
            //a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "Iwonu@gmail.com";
                customer.FirstName = "Wonuola";
                customer.LastName = "Idris";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        //Save  the current customer
        public bool Save(Customer customer)
        {
           var  SUCCESS = true;
            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {
                        // call an insert stored procedure
                    }
                    else
                    {
                        //call an update stored procedure
                    }
                }
                else
                {
                    SUCCESS = false;
                }
            }

            return SUCCESS;
        }
    }
}