using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ApplicationCore.ImportModels
{
    [XmlRoot("payment")]
    public class ImportPaymentItem
    {
        [XmlElement("processor-id")]
        public string ProcessorId { get; set; }

        [XmlElement("amount")]
        public decimal Amount { get; set; }
    }

    [XmlRoot(ElementName = "payments")]
    public class ImportPaymentsModel
    {
        [XmlElement(ElementName = "payment")]
        public ImportPaymentItem[] Items { get; set; }
    }
}
