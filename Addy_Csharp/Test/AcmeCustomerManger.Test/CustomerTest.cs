using System;
using AcmeCustomerManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcmeCustomerManger.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameValidation()
        {
            //-- Arrange
            var customer = new Customer
            {
                FirstName = "Tadwai",
                LastName = "Adarsh"
            };
            string expected = "Tadwai, Adarsh";

            //-- Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // --Arrange
            var customer = new Customer
            {
                FirstName = "Tadwai"
            };
            string expected = "Tadwai";
            // --Act
            string actual = customer.FullName;
            // --Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void  FullNameFirstNameEmpty()
        {
            //--Arrange
            var customer = new Customer
            {
                LastName = "Adarsh"
            };
            string expected = "Adarsh";
            //--Act
            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void checkValidate()
        {
            var customer = new Customer
            {
                LastName = "Adarsh",
                EmailAddress = "adarshtadwai@gmail.com"
            };
            var actual = customer.Validate();
            Assert.AreEqual(actual, true);
        }
    }
}
