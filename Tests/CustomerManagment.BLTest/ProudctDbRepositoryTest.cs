using System;
using CustomerManagement.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagment.BLTest
{
    [TestClass]
    public class ProudctDbRepositoryTest
    {
        [TestMethod]
        public void ValidRetrieve()
        {
            //Assert
            var productRepo = new ProductDbRepository();
            var expected = new Product(1)
            {
                ProductName = "Boots",
                CurrentPrice = 50.45,
                Description = "Nike CR7 boots for a great price"

            };

            //Act
            var actual = productRepo.RetrieveById(1);

            //Assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.Description, actual.Description);

        }
    }
}
