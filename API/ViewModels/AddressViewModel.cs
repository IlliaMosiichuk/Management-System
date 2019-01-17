using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class AddressViewModel
    {
        public string Email { get; set; }

        public EAddressType Type { get; set; }
    }
}
