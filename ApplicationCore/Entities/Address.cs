using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Address : BaseEntity
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Street { get; set; }

        public string StreetNumber { get; set; }

        public string Status { get; set; }

        public string City { get; set; }

        public Country Country { get; set; }
        public long CountryId { get; set; }

        public string Title { get; set; }

        public string Phone { get; set; }

        public EAddressType Type { get; set; }

        public Order Order { get; set; }
        public long OrderId { get; set; }
    }

    public enum EAddressType
    {
        Billing,
        Delivery,
    }
}
