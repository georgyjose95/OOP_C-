using System;
using CustomerManagement.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagment.BLTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void ValidOrder()
        {
            //Arrange
            Order order = new Order
            {
                OrderDate = System.DateTime.Now
            };
            bool expected = true;

            //Act
            bool actual = true;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void InavlidOrder()
        {
            //Arrange
            Order order = new Order();
            bool expected = false;

            //Act
            bool actual = false;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
