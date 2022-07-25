using System.Collections.Generic;

namespace ACMEMgt
{
    public class AddressRepository
    {
        public Address Retrieve(int addressid)
        {
            Address address = new Address(addressid);
            //code that retrieve the defined address

            //Temporary hard coded values to return a populated address

            if (addressid == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Baggot row";
                address.State = "hobbiton";
                address.City = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int cudtomderId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Idowu Taylor",
                StreetLine2 = "Marina",
                City = "Lagos",
                State = "Lagos",
                Country = "Nigeria",
                PostalCode = "234"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Taiwo Taylor",
                StreetLine2 = "Marina Street",
                City = "Lagos",
                State = "Lagos",
                Country = "Nigeria",
                PostalCode = "234"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            var SUCCESS = true;
            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
                    {
                        // call an insert stored procedure
                    }
                    else
                    {
                        //call an update stored procedure
                    }
                }
                else
                {
                    SUCCESS = false;
                }
            }

            return SUCCESS;
        }
    }
}