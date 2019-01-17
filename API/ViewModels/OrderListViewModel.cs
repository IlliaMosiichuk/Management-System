using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class OrderListViewModel
    {
        public OrderListViewModel()
        {
            Orders = new List<OrderListItemViewModel>();
        }

        public List<OrderListItemViewModel> Orders { get; set; }
    }
}
