using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.BL
{
    public class ProductDbRepository
    {
        public Product RetrieveById(int productId)
        {
            Product product = new Product(productId);

            //Code for retrieving the customer based on the Id

            //hard-coded
            if(product.ProductId == 1)
            {
                product.ProductName = "Boots";
                product.CurrentPrice = 50.45;
                product.Description = "Nike CR7 boots for a great price";
            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"ProductObject : {product.ToString()}");

            return product;

        }
        public bool Save(Product product)
        {
            // Code that save the product into the database
            return true;
        }
    }
}
