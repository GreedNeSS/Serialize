using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLExample
{ 
    [Serializable]
    public class Person
    {
        [XmlAttribute]
        public string? Name { get; set; }
        [XmlAttribute]
        public int Id { get; set; }
        [XmlAttribute]
        public int Age { get; set; }
        [XmlElement]
        public Company Company { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Id: {Id}, Company: {Company.Title}";
        }
    }
}
