using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerManagement.BL;
using System.Collections.Generic;

namespace CustomerManagment.BLTest
{
    [TestClass]
    public class CustomerDbRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Arrange
            var customerRepo = new CustomerDbRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "cristiano@juventus.com",
                FirstName = "Cristiano",
                LastName = "Ronaldo",

            };

            //Act
            var actual = customerRepo.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveCustomersWithAddress()
        {
            //Arrange
            var customerRepo = new CustomerDbRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "cristiano@juventus.com",
                FirstName = "Cristiano",
                LastName = "Ronaldo",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        StreetLine1 = "123 Abc",
                        StreetLine2 = "Abc apartment",
                        City = "Abc",
                        State = "Abc",
                        Country = "Abc",
                        PostalCode = "1231AF",
                        AddressType = AddressTypes.Home
                    },
                    new Address()
                    {

                         StreetLine1 = "123 Xyz",
                         StreetLine2 = "Xyxzapartment",
                         City = "Xyz",
                         State = "Xyz",
                         Country = "Xyz",
                         PostalCode = "1231XZ",
                         AddressType = AddressTypes.Work
                    }
                }

            };
            //Act
            var actual = customerRepo.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            for(int i= 0; i <=1; i++)
            {
               // Assert.AreEqual(expected.AddressList[i].AddressId, actual.AddressList[i].AddressId);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
            }
        }

        [TestMethod]
        public void ValidSave()
        {
            //Arrange
            var customerRepo = new CustomerDbRepository();
            var newCustomer = new Customer(1)
            {
                EmailAddress = "cristiano@juventus.com",
                FirstName = "Cristiano",
                LastName = "Ronaldo",
                CustomerType = CustomerTypes.Businness,
                HasChanges = true
            };

            //Act 
            var actual = customerRepo.Save(newCustomer);

            //Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void InValidSave()
        {
            //Arrange
            var customerRepo = new CustomerDbRepository();
            var newCustomer = new Customer(1)
            {
                EmailAddress = "cristiano@juventus.com",
                FirstName = null,
                LastName = "Ronaldo",
                CustomerType = CustomerTypes.Businness,
                HasChanges = true
            };

            //Act 
            var actual = customerRepo.Save(newCustomer);

            //Assert
            Assert.AreEqual(false, actual);
        }
    }

}
