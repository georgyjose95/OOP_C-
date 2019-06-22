using System;
using System.Collections.Generic;
using System.Text;
using CommonCL;
namespace CustomerManagement.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; private set; }
        public string Description { get; set; }
        public double? CurrentPrice { get; set; }
        private string productName;
        public string ProductName
        {// The requirements says the product details is obtained from a Third party system and there is no space between the product Name so we write general purpose codes 
            get
            {
                //return StringHandler.InsertSpace(productName); // Static method that is not innstantiated but can access the members using the class name.
                return productName.InsertSpace(); // Extension method used and added to string of .net type. 
            }
            set
            {
                productName = value;
            }
        }

        // Logging of product
        public string Log() => $"{ProductId} : {ProductName} --> Price: {CurrentPrice} , Details : {Description} Availability : {EntityState.ToString()}";
        public override string ToString() => ProductName;
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) { isValid = false; }
            if (CurrentPrice == null) isValid = false;
            if (string.IsNullOrWhiteSpace(Description))  isValid = false;
            return isValid;
        }
    }
}
