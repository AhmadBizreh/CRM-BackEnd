using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public class Address
    {

        public int AddressId { get; set; }
        public string Addressline1 { get; set; }
        public string Addressline2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string  PostalCode { get; set; }
        public string Country { get; set; }
        public Boolean Shippingaddress  { get; set; }
        public Boolean Billingaddress { get; set; }




        public Customer Customer { get; set; }
        public string CustomerId { get; set; }

    }
}
