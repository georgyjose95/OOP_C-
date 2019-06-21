using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerManagement.BL;

namespace CustomerManagment.BLTest
{
    [TestClass]
    public class OrderItemsDbRepositoryTest
    {
        [TestMethod]
        public void ValidRetireve()
        {
            // Arrange
            var orderedItemsRepo = new OrderItemsDbRepository();
            var expected = new OrderItems(1)
            {
                Product = "Boots"
            };

            //Act
            var actual = orderedItemsRepo.RetrieveById(1);

            //Assert
            Assert.AreEqual(expected.OrderItemId, actual.OrderItemId);

        }

        [TestMethod]
        public void ValidSave()
        {
            //Arrange
            var orderedItemsRepo = new OrderItemsDbRepository();
            var newOrderedItem = new OrderItems(1)
            {
                Product = "Boots",
                HasChanges = true,
                PurchasePrice = 50.45,
                Quantity = 2
            };

            //Act 
            var actual = orderedItemsRepo.Save(newOrderedItem);

            //Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void InValidSave()
        {
            //Arrange
            var orderedItemsRepo = new OrderItemsDbRepository();
            var newOrderedItem = new OrderItems(1)
            {
                Product = "Boots",
                HasChanges = true,
                PurchasePrice = null,
                Quantity = 2
            };

            //Act 
            var actual = orderedItemsRepo.Save(newOrderedItem);

            //Assert
            Assert.AreEqual(false, actual);
        }
    }
}
