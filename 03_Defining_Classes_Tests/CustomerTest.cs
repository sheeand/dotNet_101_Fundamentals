using System;
using _03_Defining_Classes_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Defining_Classes_Tests
{
    [TestClass]
    public class CustomerTest
    {
        //-- Field
        private Customer _customer;

        [TestInitialize]
        public void Arrange()
        {
            //-- Arrange
            _customer = new Customer();
            _customer.CustomerID = 1;
            _customer.LastName = "Pascascio";
            _customer.NumberOfItemsPurchased = 4000;
            _customer.Age = 27;
        }

        [TestMethod]
        public void Customer_SetLastName_IsString()
        {
            //-- Act
            var expected = "Pascascio";
            var actual = _customer.LastName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Customer_CustomerID_IsInt()
        {
            //-- Act
            var expected = 1;
            var actual = _customer.CustomerID;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Customer_NumberOfItemsPurchased_IsCorrectInt()
        {
            //-- Act
            var expected = 4000;
            var actual = _customer.NumberOfItemsPurchased;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Customer_SetAge_IsCorrectInt()
        {
            //-- Act
            var expected = 27;
            var actual = _customer.Age;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
