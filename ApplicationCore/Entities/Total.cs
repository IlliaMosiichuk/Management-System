using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Total : BaseEntity
    {
        public decimal Discount { get; set; }

        public decimal Net { get; set; }

        public decimal Brut { get; set; }

        public decimal DeliveryCost { get; set; }

        public decimal Sum { get; set; }

        //public Order Order { get; set; }

        //public long OrderId { get; set; }
    }
}
