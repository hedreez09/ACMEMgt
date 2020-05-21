using System;
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
				LastName = "Idris"
			};

			//Act
			var actual = customerRepository.Retrieve(1);

			///Assert to compare the objects 
			Assert.AreEqual(expected.CustomerId, actual.CustomerId);
			Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
			Assert.AreEqual(expected.FirstName, actual.FirstName);
			Assert.AreEqual(expected.LastName, actual.LastName);
		}
	}
}
