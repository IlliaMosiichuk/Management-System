using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ApplicationCore.ImportModels
{
    [XmlRoot("totals")]
    public class ImportTotalModel
    {
        [XmlElement("oxdiscount")]
        public decimal Discount { get; set; }

        [XmlElement("oxtotalnetsum")]
        public decimal Net { get; set; }

        [XmlElement("oxtotalbrutsum")]
        public decimal Brut { get; set; }

        [XmlElement("oxdelcost")]
        public decimal DeliveryCost { get; set; }

        [XmlElement("oxtotalordersum")]
        public decimal Sum { get; set; }
    }
}
