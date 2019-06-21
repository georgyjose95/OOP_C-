using System;
using CustomerManagement.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagment.BLTest
{
    [TestClass]
    public class OrderDbRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Assert
            var orderRepo = new OrderDbRepository();
            var expected = new Order(1)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 10, 12, 14, 25, 45, new TimeSpan(4, 0, 0))
            };

            //Act 
            var actual = orderRepo.RetrieveById(1);

            //Assert
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
        [TestMethod]
        public void ValidSave()
        {
            //Assert
            var orderRepo = new OrderDbRepository();
            var newOrder = new Order(1)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 10, 12, 14, 25, 45, new TimeSpan(4, 0, 0)),
                HasChanges = true,
                EntityState = EntityStateOption.Active,

            };

            //Act 
            var actual = orderRepo.Save(newOrder);

            //Assert
            Assert.AreEqual(true, actual);

        }
        [TestMethod]
        public void InValidSave()
        {
            //Assert
            var orderRepo = new OrderDbRepository();
            var newOrder = new Order(1)
            {
                OrderDate = null,
                HasChanges = true,
                EntityState = EntityStateOption.Active,

            };

            //Act 
            var actual = orderRepo.Save(newOrder);

            //Assert
            Assert.AreEqual(false, actual);

        }
    }
}
   
