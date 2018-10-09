using System;
using _02_Reference_Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Reference_Types_Unit_Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void Customer_SetFirstName_ShouldBeString()
        {
            //-- Arrange
            var customer = new Customer();
            customer.FirstName = "Shivjeet";

            //-- Act
            var actual = customer.FirstName;
            var expected = "Shivjeet";

            Console.WriteLine($"Actual:{actual}");

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Customer_SetLastName_ShouldBeString()
        {
            //-- Arrange
            var customer = new Customer();
            customer.LastName = "Jauhal";

            //-- Act
            var expected = "Jauhal";
            var actual = customer.LastName;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        //TODO: Test for HW.


    }
}
