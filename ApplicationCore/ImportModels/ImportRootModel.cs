using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ApplicationCore.ImportModels
{
    [XmlRoot("orders")]
    public class ImportRootModel
    {
        [XmlElement("order")]
        public ImportOrderModel[] Orders { get; set; }
    }
}
