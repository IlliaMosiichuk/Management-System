using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class OrderListItemViewModel
    {
        public long Id { get; set; }

        public string Number { get; set; }

        public string OrderDate { get; set; }

        public bool Processed { get; set; }

        public string TrackingNumber { get; set; }

        public string Reference { get; set; }

        public TotalViewModel Total { get; set; }

        public List<AddressViewModel> Addresses { get; set; }

        public List<ArticleListItemViewModel> Articles { get; set; }

        public List<PaymentListItemViewModel> Payments { get; set; }
    }
}
