using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.BL
{
    public class OrderItems :EntityBase
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
        public override string ToString() => $"{OrderItemId} --> ({Product})";

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Product)) isValid = false; 
            if (PurchasePrice == null) isValid = false;
            if (Quantity == null) isValid = false;
            return isValid;
        }
    }
}
