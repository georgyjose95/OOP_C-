using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.BL
{
    public class OrderDbRepository
    {

        public Order RetrieveById(int orderId)
        {
            Order order = new Order(1);
            //Code for retrieving the customer based on the Id

            //Hard coded
            if(order.OrderId == 1)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 10, 12, 14, 25, 45, new TimeSpan(4, 0, 0));
            }
            return order;

        }
        public bool Save()
        {
            // Save the customer to the database
            return true;
        }
    }
}
