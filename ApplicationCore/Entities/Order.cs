using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Order : BaseEntity
    {
        public Order()
        {
            Articles = new List<Article>();
            Payments = new List<Payment>();
            Addresses = new List<Address>();
        }

        public string ShopId { get; set; }

        public string OrderDate { get; set; }

        public string Number { get; set; }

        public string Provider { get; set; }

        public string Device { get; set; }

        public string Currency { get; set; }

        public string PaymentType { get; set; }

        public bool Processed { get; set; }

        public string Comment { get; set; }

        public string Reference { get; set; }

        public string TrackingNumber { get; set; }

        [ForeignKey("TotalId")]
        public Total Total { get; set; }

        [ForeignKey("Total")]
        public long TotalId { get; set; }

        public ICollection<Address> Addresses { get; set; }
        public ICollection<Article> Articles { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
