using ACMEMgt;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMEMgtTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                ProductName = "Samosa",
                ProductDescription = "Finger food",
                CurrentPrice = 23.34M
            };

            //Act
            var actual = productRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}