using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.BL
{
    public class OrderItemsDbRepository
    {

        public OrderItems RetrieveById(int orderId)
        {
            OrderItems orderedItems = new OrderItems(1);
            //Code for retrieving the customer based on the Id

            //Hard coded
            if ( orderedItems.OrderItemId== 1)
            {
                orderedItems.Product = "Boots";
            }
            Console.WriteLine($"ToString Overrided in the Order class : {orderedItems.ToString()}");
            return orderedItems;

        }

        public bool Save(OrderItems orderedItems)
        {
            var success = true;

            if (orderedItems.HasChanges)
            {
                if (orderedItems.IsValid)
                {
                    if (orderedItems.IsNew)
                    {
                        // Call an insert stored procedure
                    }
                    else
                    {
                        // Call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;

        }

    }
}
