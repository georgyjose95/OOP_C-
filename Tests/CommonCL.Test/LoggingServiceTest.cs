using System;
using System.Collections.Generic;
using CustomerManagement.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonCL.Test
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void ValidLogging()
        {
            //Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(3)
            {
                FirstName = "Sergio",
                LastName = "Ramos",
                CustomerType = CustomerTypes.Premium,
                EmailAddress = "sergio_ramos@realmadrid.com",
                EntityState = EntityStateOption.Active
            };
            changedItems.Add(customer);

            var product = new Product(3)
            {
                ProductName = "Socks",
                EntityState = EntityStateOption.Active,
                CurrentPrice = 10.25,
                Description = "White socks with team logo printed from Addidas"
            };
            changedItems.Add(product);

            //Act
            LoggingServices.WriteToFile(changedItems);

            //Assert
            //Nothing to validate

        }
    }
}
