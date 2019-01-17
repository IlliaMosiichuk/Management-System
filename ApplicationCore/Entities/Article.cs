using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Article : BaseEntity
    {
        public string Number { get; set; }

        public string Title { get; set; }

        public decimal Amount { get; set; }

        public decimal BrutPrice { get; set; }

        public decimal NetPrice { get; set; }

        public decimal Vat { get; set; }

        public decimal VatPrice { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [ForeignKey("Order")]
        public long OrderId { get; set; }
    }
}
