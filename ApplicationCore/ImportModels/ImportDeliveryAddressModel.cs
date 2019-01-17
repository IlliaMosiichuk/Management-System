using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ApplicationCore.ImportModels
{
    [XmlRoot("oxdeliveryaddress")]
    public class ImportDeliveryAddressModel
    {
        [XmlElement("oxdelemail")]
        public string Email { get; set; }

        [XmlElement("oxdelfname")]
        public string FirstName { get; set; }

        [XmlElement("oxdellname")]
        public string LastName { get; set; }

        [XmlElement("oxdelstreet")]
        public string Street { get; set; }

        [XmlElement("oxdelstreetnr")]
        public string StreetNumber { get; set; }

        [XmlElement("oxdelustidstatus")]
        public string Status { get; set; }

        [XmlElement("oxdelcity")]
        public string City { get; set; }

        [XmlElement("country")]
        public ImportCountryModel Country { get; set; }

        [XmlElement("oxdelzip")]
        public string ZipCode { get; set; }

        [XmlElement("oxdelfon")]
        public string Phone { get; set; }

        [XmlElement("oxdelsal")]
        public string Title { get; set; }
    }
}
