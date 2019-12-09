using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Zeth.Developer.Data;

namespace Zeth.Developer.Interop.Model
{
    public class Project
    {
        [XmlAttribute]
        public Guid Guid { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string TypeName { get; set; }
        [XmlElement]
        public string Description { get; set; }
        [XmlElement]
        public List<Guid> Items { get; set; }

        public override string ToString()
        {
            return $"{Strings.NamInteropProject}/{TypeName}/{Guid.ToString()}";
        }
    }
}
