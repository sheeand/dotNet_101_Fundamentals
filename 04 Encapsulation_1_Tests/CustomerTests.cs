using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_Encapsulation_1;

namespace _04_Encapsulation_1_Tests
{

    [TestClass]
    public class CustomerTests
    {
        private CustomerQueueRepository repo = new CustomerQueueRepository();
        private Customer cust1 = new Customer("Dave", "Jones", 35, "What's my balance?");
        private Customer cust2 = new Customer("Mark", "Smith", 35, "Can I do this?");
        private Customer cust3 = new Customer("John", "West", 35, "How many kinds are there?");

        [TestInitialize]
        public void Arrange()
        {
            repo.AddNewCallerToQueue(cust1);
            repo.AddNewCallerToQueue(cust2);
            repo.AddNewCallerToQueue(cust3);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Customer customer = new Customer {FirstName = "Kenn", LastName = "Star    "};
            Console.WriteLine(customer.LastName);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Name cannot be empty")]
        public void Customer_ExceptionIfNameNull_ShouldThrowException()
        {
            // Arrange
            var customer = new Customer("Dave", "Jones", 35, "How tall are you?");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Name cannot be empty")]
        public void Customer_ExceptionIfNameNull_ShouldThrowCorrectException()
        {
            // Arrange
            var customer = new Customer("Dave", "Jones", 35, "How tall are you?");
        }

        [TestMethod]
        public void CustQueueRepo_AddNewCaller_FirstShouldBeOnTopOfQueue()
        {
            Arrange();

        }
    }
}
