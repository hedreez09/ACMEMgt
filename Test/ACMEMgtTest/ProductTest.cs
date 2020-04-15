using ACMEMgt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEMgtTest
{
	[TestClass]
	public class ProductTest
	{
		[TestMethod]
		public void ProductNameNotNull()
		{
			// arrange
			Product product = new Product
			{
				ProductName = "Goodiebag"
			};
			string expected = "Goodiebag";

			//Act
			string actual = product.ProductName;

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ValidateValid()
		{
			// arrange
			Product product = new Product
			{
				ProductName = "Goodiebag",
				CurrentPrice = 234
			};

			var expected = true;

			//Act
			var actual = product.Validate();

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ValidateMissingCurrentPrice()
		{
			// arrange
			Product product = new Product
			{
				ProductName = "Goodiebag"	
			};

			var expected = false;

			//Act
			var actual = product.Validate();

			//Assert
			Assert.AreEqual(expected, actual);
		}

	}
}
