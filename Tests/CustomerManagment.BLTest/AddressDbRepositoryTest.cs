using System;
using CustomerManagement.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagment.BLTest
{
    [TestClass]
    public class AddressDbRepositoryTest
    {
        [TestMethod]
        public void RetrieveAddress()
        {
            //Assert
            var addressRepo = new AddressDbRepository();
            var expected = new Address(1)
            {
                StreetLine1 = "123 Abc",
                StreetLine2 = "Abc apartment",
                City = "Abc",
                State = "Abc",
                Country = "Abc",
                PostalCode = "1231AF",
                AddressType = 1
            };

            //Act
            var actual = addressRepo.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.AddressId, actual.AddressId);
            Assert.AreEqual(expected.StreetLine1, actual.StreetLine1);
            Assert.AreEqual(expected.StreetLine2, actual.StreetLine2);
            Assert.AreEqual(expected.City, actual.City);
            Assert.AreEqual(expected.State, actual.State);
            Assert.AreEqual(expected.Country, actual.Country);
            Assert.AreEqual(expected.PostalCode, actual.PostalCode);
            Assert.AreEqual(expected.AddressType, actual.AddressType);

        }
    }
}
