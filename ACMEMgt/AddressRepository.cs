﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEMgt
{
	public class AddressRepository
	{
		public Address Retrieve(int addressid)
		{
			Address address = new Address(addressid);
			//code that retrieve the defined address

			//Temporary hard coded values to return a populated address 

			if(addressid == 1)
			{
				address.AddressType = 1;
				address.StreetLine1 = "Bag End";
				address.StreetLine2 = "Baggot row";
				address.State = "hobbiton";
				address.City = "Middle Earth";
				address.PostalCode = "144";
			}
			return address;
		}

		public IEnumerable<Address> RetrieveByCustomerId(int cudtomderId)
		{
			var addressList = new List<Address>();
			Address address = new Address(1)
			{
				AddressType = 1,
				StreetLine1 = "Idowu Taylor",
				StreetLine2 = "Marina",
				City = "Lagos",
				State = "Lagos",
				Country = "Nigeria",
				PostalCode = "234"
			};
			addressList.Add(address);


			 address = new Address(2)
			{
				AddressType = 2,
				StreetLine1 = "Taiwo Taylor",
				StreetLine2 = "Marina Street",
				City = "Lagos",
				State = "Lagos",
				Country = "Nigeria",
				PostalCode = "234"
			};
			addressList.Add(address);

			return addressList;
		}
		public bool Save(Address address)
		{
			//code that saves the passed in addresss
			return true;                                                                                                                                                                                                                                                                                                                                 
		}

	}
}
