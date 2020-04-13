using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEMgt
{
    public class Customer
    {
		public Customer()
		{

		}
		public Customer( int customerId)
		{
			CustomerId = customerId;
		}
		public int CustomerId { get; private set; }
		public string FirstName { get; set; }
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

		//To retrieve one customer 
		public Customer Retrieve(int customerId)
		{
			//code that retrieve the specified customer
			return new Customer();
		}

		//To retrieve all customers
		public List<Customer> Retrieve()
		{
			//code that retrieve all customer
			return new List<Customer>();
		}

		//To Save the current customer
		public bool Save()
		{
			//Code that save the defiened customer
			return true;
		}

		//To validate that the specified field are required and not null
		public bool Validate()
		{
			var isValid = true;
			if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
			if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

			return isValid;
		}
	}
}
