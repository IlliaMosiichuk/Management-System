using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Payment : BaseEntity
    {
        public string ProcessorId { get; set; }

        public decimal Amount { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [ForeignKey("Order")]
        public long OrderId { get; set; }
    }
}
