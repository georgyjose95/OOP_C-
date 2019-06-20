using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double? CurrentPrice { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) { isValid = false; }
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
    }
}
