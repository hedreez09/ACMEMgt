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


        [TestMethod]
        public void SaveTestValid()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "BIg size of Ground Oil",
                ProductName = "Power oil",
                HasChanges = true
            };
            //act
           var actual = productRepository.Save(updatedProduct);
            //Assert
            Assert.AreEqual(true, actual);
        }


        [TestMethod]
        public void SaveTestInValid()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "BIg size of Ground Oil",
                ProductName = "Power oil",
                HasChanges = true
            };
            //act
            var actual = productRepository.Save(updatedProduct);
            //Assert
            Assert.AreEqual(false, actual);
        }
    }


}