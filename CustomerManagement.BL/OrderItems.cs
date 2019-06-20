using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.BL
{
    public class OrderItems
    {
        public OrderItems()
        {

        }
        public OrderItems(int orderItemId)
        {
            OrderItemId= orderItemId;
        }
        public int OrderItemId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double?  PurchasePrice { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Product)) isValid = false; 
            if (PurchasePrice == null) isValid = false;
            if (Quantity == null) isValid = false;
            return isValid;
        }
        public bool Save()
        {
            // Save the customer to the database
            return true;
        }
    }
}
