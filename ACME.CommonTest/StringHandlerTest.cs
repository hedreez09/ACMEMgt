using ACME.Common1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACME.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //Arrange
            var source = "PayrollSystem";
            var expected = "Payroll System";

            //Act
            var actual = StringHandler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void INsertSpaceTestWithExistingSpace()
        {
            //Arrange
            var source = "Payroll System";
            var expected = "Payroll System";

            //act
            var actual = StringHandler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void InsertSpaceTestForEmptyString()
        {
            //arrange
            var source = " ";
            var expected = "";

            //act
            var actual = StringHandler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
