using System;
using ACMEMgt;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMEMgtTest
{
	[TestClass]
	public class CustomerTest
	{
		private const bool V = true;

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

		[TestMethod]
		public void ValidateValid()
		{
			// arrange
			Customer customer = new Customer
			{
				LastName = "Yusuf",
				EmailAddress = "Aje@Gmail.com"
			};

			var expected = true;

			//Act
			var actual = customer.Validate();

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ValidateMissingLastname()
		{
			// arrange
			Customer customer = new Customer
			{
				
				EmailAddress = "Aje@Gmail.com"
			};

			var expected = false;

			//Act
			var actual = customer.Validate();

			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
