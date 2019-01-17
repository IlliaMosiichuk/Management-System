using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ApplicationCore.ImportModels
{
    [XmlRoot(ElementName = "orderarticle")]
    public class ImportArticleItem
    {
        [XmlElement("oxartnum")]
        public string Number { get; set; }

        [XmlElement("oxtitle")]
        public string Title { get; set; }

        [XmlElement("oxamount")]
        public decimal Amount { get; set; }

        [XmlElement("oxbprice")]
        public decimal BrutPrice { get; set; }

        [XmlElement("oxnetprice")]
        public decimal NetPrice { get; set; }

        [XmlElement("oxvat")]
        public decimal Vat { get; set; }

        [XmlElement("oxvatprice")]
        public decimal VatPrice { get; set; }

    }


    [XmlRoot(ElementName = "articles")]
    public class ImportArticlesModel
    {
        [XmlElement(ElementName = "orderarticle")]
        public List<ImportArticleItem> Items { get; set; }
    }
}
