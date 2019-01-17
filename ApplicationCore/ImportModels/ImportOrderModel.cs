using ApplicationCore.ImportModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ApplicationCore
{
    [XmlRoot("order")]
    public class ImportOrderModel
    {
        [XmlElement("oxshopid")]
        public string ShopId { get; set; }

        [XmlElement("oxorderdate")]
        public string OrderDate { get; set; }

        [XmlElement("oxordernr")]
        public string Number { get; set; }

        [XmlElement("provider")]
        public string Provider { get; set; }

        [XmlElement("device")]
        public string Device { get; set; }

        [XmlElement("oxdeltype")]
        public string DeliveryType { get; set; }

        [XmlElement("oxcurrency")]
        public string Currency { get; set; }

        [XmlElement("oxpaymenttype")]
        public string PaymentType { get; set; }

        [XmlElement("oxbillingaddress")]
        public ImportBillingAddressModel BillingAddress { get; set; }

        [XmlElement("oxdeliveryaddress")]
        public ImportDeliveryAddressModel DeliveryAddress { get; set; }

        [XmlElement("totals")]
        public ImportTotalModel Total { get; set; }

        [XmlElement("articles")]
        public ImportArticlesModel Articles { get; set; }

        [XmlElement("payments")]
        public ImportPaymentsModel Payments { get; set; }
    }



}
