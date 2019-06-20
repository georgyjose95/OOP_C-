using System;
using System.Collections.Generic;

namespace CustomerManagement.BL
{
    public class Customer
    {
        public Customer() : this(0) // Constructor chaining used when a constructor want to call another constructor. Default value of 0 is passed for Id
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>(); //Since list do not have a default value when initialiazed when the property is 
            //without initialization can result in null value expection. 
        }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> AddressList { get; set; } // Implements a 'has a' composition relationship with the address class
        public static int InstanceCount { get; set; }

        public string FullName
        {
            get
            {
                string fullName = FirstName;
                if (!string.IsNullOrWhiteSpace(LastName))
                { 
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += " ";
                    }
                    fullName += LastName;
                }
                return fullName;
            }
        }
        //Validate - checks whethere the field is null
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) { isValid = false; }
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }
    }
}
