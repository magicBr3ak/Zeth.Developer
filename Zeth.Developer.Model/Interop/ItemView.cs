using System;
using System.Xml.Serialization;

namespace Zeth.Developer.Interop
{
    public class ItemView
    {
        [XmlAttribute]
        public Guid ItemGuid { get; set; }
        [XmlAttribute]
        public Guid ViewGuid { get; set; }
    }
}
