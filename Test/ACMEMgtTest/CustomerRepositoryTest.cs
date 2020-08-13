using System;
using System.Collections.Generic;
using ACMEMgt;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMEMgtTest
{
	[TestClass]
	public class CustomerRepositoryTest
	{
		[TestMethod]
		public void RetrieveValid()
		{
			//Arrange
			var customerRepository = new CustomerRepository();
			var expected = new Customer(1)
			{
				EmailAddress = "Iwonu@gmail.com",
				FirstName = "Wonuola",
				LastName = "Idris",
				AddressList = new List<Address>() //test composition of classes
				{
					new Address()
					{
						AddressType = 1,
						StreetLine1 = "Idowu Taylor",
						StreetLine2 = "Marina",
						City = "Lagos",
						State = "Lagos",
						Country = "Nigeria",
						PostalCode = "234"
					},
					new Address()
					{
						AddressType = 2,
						StreetLine1 = "Idowu Taylor",
						StreetLine2 = "Marina",
						City = "Lagos",
						State = "Lagos",
						Country = "Nigeria",
						PostalCode = "234"
					}
				}
			};

			//Act
			var actual = customerRepository.Retrieve(1);

			///Assert to compare the objects 
			Assert.AreEqual(expected.CustomerId, actual.CustomerId);
			Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
			Assert.AreEqual(expected.FirstName, actual.FirstName);
			Assert.AreEqual(expected.LastName, actual.LastName);

			for (int i = 0; i < 1; i++)
			{
				Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
				Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
				Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
				Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
				Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
				Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);

			}
		}
	}
}
