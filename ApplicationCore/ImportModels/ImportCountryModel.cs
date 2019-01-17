using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ApplicationCore.ImportModels
{
    public class ImportCountryModel
    {
        [XmlElement("oxisoalpha2")]
        public string Code { get; set; }
    }
}
