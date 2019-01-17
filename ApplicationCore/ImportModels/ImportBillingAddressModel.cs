using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ApplicationCore.ImportModels
{
    [XmlRoot("oxbillingaddress")]
    public class ImportBillingAddressModel
    {
        [XmlElement("oxbillemail")]
        public string Email { get; set; }

        [XmlElement("oxbillfname")]
        public string FirstName { get; set; }

        [XmlElement("oxbilllname")]
        public string LastName { get; set; }

        [XmlElement("oxbillstreet")]
        public string Street { get; set; }

        [XmlElement("oxbillstreetnr")]
        public string StreetNumber { get; set; }

        [XmlElement("oxbillustidstatus")]
        public string Status { get; set; }

        [XmlElement("oxbillcity")]
        public string City { get; set; }

        [XmlElement("country")]
        public ImportCountryModel Country { get; set; }

        [XmlElement("oxbillzip")]
        public string ZipCode { get; set; }

        [XmlElement("oxbillsal")]
        public string Title { get; set; }

        [XmlElement("oxdelfon")]
        public string Phone { get; set; }
    }

}
