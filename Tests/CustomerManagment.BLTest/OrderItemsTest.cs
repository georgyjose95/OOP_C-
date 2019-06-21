using System;
using CustomerManagement.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagment.BLTest
{
    [TestClass]
    public class OrderItemsTest
    {
        [TestMethod]
        public void ValidOrderItem()
        {
            //Arrange
            OrderItems orderItems = new OrderItems
            {
                Product = "boots",
                PurchasePrice = 50.45,
                Quantity = 2
            };
            bool expected = true;

            //Act
            bool actual = orderItems.IsValid;

            //Assert
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void InValidOrderItem()
        {
            //Arrange
            OrderItems orderItem = new OrderItems();
            bool expected = false;

            //Act
            bool actual = orderItem.IsValid;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
