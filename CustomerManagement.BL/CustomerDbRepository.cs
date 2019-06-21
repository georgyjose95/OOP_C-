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
            Console.WriteLine($"Customer ToString() Override output: {customer.ToString()}");
            return customer;
           
        }

        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
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
