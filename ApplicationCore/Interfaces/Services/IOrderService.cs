using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ApplicationCore.Interfaces.Services
{
    public interface IOrderService
    {
        IEnumerable<Order> GetImportedOrders(Stream stream);

        void ProcessImportedOrders(IEnumerable<Order> orders);
    }
}
