using System;
using ACMEMgt;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMEMgtTest
{
	[TestClass]
	public class CustomerTest
	{
		[TestMethod]
		public void FullNameTestValid()
		{
			// arrange
			Customer customer = new Customer
			{
				FirstName = "Yusuf",
				LastName = "Khadijah"
			};
			string expected = "Khadijah, Yusuf";

			//Act
			string actual = customer.FullName;

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void FullNameFirstNameEmpty()
		{
			// arrange
			Customer customer = new Customer
			{
				
				LastName = "Khadijah"
			};
			string expected = "Khadijah";

			//Act
			string actual = customer.FullName;

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void FullNameLastNameEmpty()
		{
			// arrange
			Customer customer = new Customer
			{
				FirstName = "Yusuf"
			};
			string expected = "Yusuf";

			//Act
			string actual = customer.FullName;

			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
