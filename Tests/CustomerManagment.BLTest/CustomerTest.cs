using System;
using CustomerManagement.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagment.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer
            {

                FirstName = "Cristiano",
                LastName = "Ronaldo"
            };
            string expectedName = "Cristiano Ronaldo";

            //Act
            string actualName = customer.FullName;

            //Assert
            Assert.AreEqual(expectedName,actualName);
        }
        [TestMethod]
        public void FirstNameTestValid()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Cristiano"
            };
            string expectedName = "Cristiano";

            //Act
            string actualName = customer.FullName;

            //Assert
            Assert.AreEqual(expectedName, actualName);
        }
        [TestMethod]
        public void LastNameTestValid()
        {
            //Arrange
            Customer customer = new Customer
            {
                LastName = "Ronaldo"
            };
            string expectedName = "Ronaldo";

            //Act
            string actualName = customer.FullName;

            //Assert
            Assert.AreEqual(expectedName, actualName);
        }

        [TestMethod]
        public void InstanceTest()
        {
            //Arrange
            Customer firstCustomer = new Customer();
            firstCustomer.FirstName = "Cristiano";
            Customer.InstanceCount += 1;

            Customer secondCustomer = new Customer();
            secondCustomer.FirstName = "Messi";
            Customer.InstanceCount += 1;

            Customer thridCustomer = new Customer();
            thridCustomer.FirstName = "Zidane";
            Customer.InstanceCount += 1;

            int expectedVal = 3;

            //Act
            //int actualVal = Customer.InstanceCount;
            //better use Customer.Instance directly during testing

            //Assert
            Assert.AreEqual(expectedVal, Customer.InstanceCount);
        }
        [TestMethod]
        public void Validate()
        {
            //Arrange
            Customer newCustomer = new Customer
            {
                LastName = "Bale",
                EmailAddress = "bale@gmail.com"
            };
            bool expected = true;

            //Act
            bool actual = newCustomer.Validate();

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void ValidateFalse()
        {
            //Arrange
            Customer newCustomer = new Customer
            {
                LastName = "Bale"
            };
            bool expected = false;

            //Act
            bool actual = newCustomer.Validate();

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
