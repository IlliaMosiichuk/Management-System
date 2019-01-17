using ApplicationCore.Entities;
using ApplicationCore.ImportModels;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Repositories;
using ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Infrastructure.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IEnumerable<Order> GetImportedOrders(Stream stream)
        {
            var orders = new List<Order>();

            var serializer = new XmlSerializer(typeof(ImportRootModel));
            var importRootModel = (ImportRootModel)serializer.Deserialize(stream);

            foreach (var importedOrder in importRootModel.Orders)
            {
                var order = new Order()
                {
                    Currency = importedOrder.Currency,
                    Device = importedOrder.Device,
                    Number = importedOrder.Number,
                    OrderDate = importedOrder.OrderDate,
                    PaymentType = importedOrder.PaymentType,
                    Provider = importedOrder.Provider,
                    ShopId = importedOrder.ShopId,
                    Articles = importedOrder.Articles.Items.Select(importedArticle => new Article()
                    {
                        Amount = importedArticle.Amount,
                        BrutPrice = importedArticle.BrutPrice,
                        NetPrice = importedArticle.NetPrice,
                        Number = importedArticle.Number,
                        Title = importedArticle.Title,
                        Vat = importedArticle.Vat,
                        VatPrice = importedArticle.VatPrice,
                    }).ToList(),
                    Payments = importedOrder.Payments.Items.Select(importedPayment => new Payment()
                    {
                        Amount = importedPayment.Amount,
                        ProcessorId = importedPayment.ProcessorId,
                    }).ToList(),
                    Total = new Total()
                    {
                        Brut = importedOrder.Total.Brut,
                        DeliveryCost = importedOrder.Total.DeliveryCost,
                        Discount = importedOrder.Total.Discount,
                        Net= importedOrder.Total.Net,
                        Sum = importedOrder.Total.Sum,
                    },
                };
                var billingAddress = new Address()
                {
                    City = importedOrder.BillingAddress.City,
                    Email = importedOrder.BillingAddress.Email,
                    Country = new Country()
                    {
                        Code = importedOrder.BillingAddress.Country.Code,
                    },
                    FirstName = importedOrder.BillingAddress.FirstName,
                    LastName = importedOrder.BillingAddress.LastName,
                    Phone = importedOrder.BillingAddress.Phone,
                    Status = importedOrder.BillingAddress.Status,
                    Street = importedOrder.BillingAddress.Street,
                    StreetNumber = importedOrder.BillingAddress.StreetNumber,
                    Title = importedOrder.BillingAddress.Title,
                    Type = EAddressType.Billing
                };
                order.Addresses.Add(billingAddress);

                var deliveryAddress = new Address()
                {
                    City = importedOrder.DeliveryAddress.City,
                    Email = importedOrder.DeliveryAddress.Email,
                    Country = new Country()
                    {
                        Code = importedOrder.DeliveryAddress.Country.Code,
                    },
                    FirstName = importedOrder.DeliveryAddress.FirstName,
                    LastName = importedOrder.DeliveryAddress.LastName,
                    Phone = importedOrder.DeliveryAddress.Phone,
                    Status = importedOrder.DeliveryAddress.Status,
                    Street = importedOrder.DeliveryAddress.Street,
                    StreetNumber = importedOrder.DeliveryAddress.StreetNumber,
                    Title = importedOrder.DeliveryAddress.Title,
                    Type = EAddressType.Delivery
                };
                order.Addresses.Add(deliveryAddress);

                orders.Add(order);
            }

            return orders;
        }

        public void ProcessImportedOrders(IEnumerable<Order> orders)
        {
            foreach (var order in orders)
            {
                _orderRepository.Add(order);
            }
        }
    }
}
