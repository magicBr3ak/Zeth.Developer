using System;
using System.Xml.Serialization;
using Zeth.Developer.Data;

namespace Zeth.Developer.Interop.Model
{
    public class Item
    {
        [XmlAttribute]
        public Guid Guid { get; set; }
        [XmlAttribute]
        public string TypeName { get; set; }

        public override string ToString()
        {
            return $"{Strings.NamInteropItem}/{TypeName}/{Guid.ToString()}";
        }
    }
}
