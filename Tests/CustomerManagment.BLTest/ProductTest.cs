using CustomerManagement.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagment.BLTest
{
    [TestClass]
    class ProductTest
    {
        [TestMethod]
        public void ValidProduct()
        {
            //Arrange
            Product product = new Product
            {
                ProductName = "Boots",
                CurrentPrice = 50.45
            };
            bool expected = true;

            //Act
            bool actual = product.IsValid;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void InvalidProduct()
        {
            Product product = new Product();
            bool expected = false;

            //Act
            bool actual = product.IsValid;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
