using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Zeth.Developer.Interop.Model
{
    public class Reference
    {
        [XmlAttribute]
        public Guid Guid { get; set; }
        [XmlAttribute]
        public string Name { get; set; }

        [XmlElement]
        public List<Project> Projects { get; set; }
        [XmlElement]
        public List<Item> Items { get; set; }
        [XmlElement]
        public List<View> Views { get; set; }
        [XmlElement]
        public List<ItemView> ItemViews { get; set; }
    }
}
