using ACMEMgt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACMEMgtTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 19, 20, 00, 00,
                    new TimeSpan(1, 0, 0))
            };
            var actual = orderRepository.Retrieve(10);

            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}