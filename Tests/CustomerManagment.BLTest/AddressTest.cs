using System;
using CustomerManagement.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagment.BLTest
{
    [TestClass]
    public class AddressTest
    {
        [TestMethod]
        public void ValidAddress()
        {
            //Arrange
            var expected = new Address(1)
            {
                StreetLine1 = "123 Abc",
                StreetLine2 = "Abc apartment",
                City = "Abc",
                State = "Abc",
                Country = "Abc",
                PostalCode = "1231AF",
                AddressType = AddressTypes.Home,
                HasChanges = true

            };

            //Act
            var actual = expected.Validate();

            //Assert
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void InValidAddress()
        {
            //Assert
            var newAddress = new Address(1)
            {
                StreetLine1 = "123 Abc",
                StreetLine2 = "Abc apartment",
                City = "Abc",
                State = "Abc",
                Country = "Abc",
                PostalCode = null,
                AddressType = AddressTypes.Home,
                HasChanges = true

            };

            //Act
            var actual = newAddress.Validate();

            //Assert
            Assert.AreEqual(false, actual);

        }

    }
}
