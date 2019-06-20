using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerManagement.BL
{
    public class CustomerDbRepository
    {
        public CustomerDbRepository()
        {
            addressDbRepository = new AddressDbRepository();
        }
        private AddressDbRepository addressDbRepository { get; set; }
        public Customer Retrieve(int customerId)
        {
            //Request Id is passed in as a paramter to the constructor method
            Customer customer = new Customer(customerId); //Defines a 'Use a' relationship with the customer class. 

            //Code to retrieve the customer from the database.

            //Temp  value - hardcoded
            if(customerId == 1)
            {
                customer.EmailAddress = "cristiano@juventus.com";
                customer.FirstName = "Cristiano";
                customer.LastName = "Ronaldo";
                customer.AddressList = addressDbRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;

        }

        public bool Save(Customer customer)
        {
            // Code that save the customer into the database
            return true;
        }
    }
}
