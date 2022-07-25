using ACME.Common1;
using ACMEMgt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACME.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //Arrange
            var changedItem = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "test1@testmail.com",
                FirstName = "Frosh",
                LastName = "Ajanlekoko",
                AddressList = null
            };
            changedItem.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Shifon",
                ProductDescription = "Clothing Material",
                CurrentPrice = 6m
            };
            changedItem.Add(product);

            //Act
            LoggingService.WriteToFile(changedItem);   
        }


    }
}
