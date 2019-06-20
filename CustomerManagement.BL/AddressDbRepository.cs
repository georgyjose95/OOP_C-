using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.BL
{
    public class AddressDbRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(1);

            //Code to retrieve the content from db

            //Hard coded sample
            if(address.AddressId == 1)
            {
                address.StreetLine1 = "123 Abc";
                address.StreetLine2 = "Abc apartment";
                address.City = "Abc";
                address.State = "Abc";
                address.Country = "Abc";
                address.PostalCode = "1231AF";
                address.AddressType = 1;
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            List<Address> addressList = new List<Address>();
            //Adding the first address to a list of addresses
            Address address1 = new Address(1)
            {
                StreetLine1 = "123 Abc",
                StreetLine2 = "Abc apartment",
                City = "Abc",
                State = "Abc",
                Country = "Abc",
                PostalCode = "1231AF",
                AddressType = 1
            };
            addressList.Add(address1);

            Address address2 = new Address(2)
            {
                StreetLine1 = "123 Xyz",
                StreetLine2 = "Xyxzapartment",
                City = "Xyz",
                State = "Xyz",
                Country = "Xyz",
                PostalCode = "1231XZ",
                AddressType = 2
            };
            addressList.Add(address2);
            return addressList;
        }
        public bool Save(Address address)
        {
            // Code to save content into repository

            return true;
        }
    }
}
