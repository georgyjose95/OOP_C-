using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.BL
{
    public class Order : EntityBase
    {
        public Order(): this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            orderedItems = new List<OrderItems>();

        }
        public int CustomerId { get; set; }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItems> orderedItems { get; set; }
        public int ShippingAddressId { get; set; }
        public override string ToString() => $"{OrderDate}--->({OrderId})";
        public override bool Validate()
        {
            var isValid = true;
            if(OrderDate == null)  isValid = false; 
            return isValid;
        }
    }
}
