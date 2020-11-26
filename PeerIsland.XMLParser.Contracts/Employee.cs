using System;
using System.Xml.Serialization;

namespace PeerIsland.XMLParser.Contracts
{
    [Serializable]
    
    public class Employee
    {
        public string name { get; set; }

        public string age { get; set; }

        public string designation { get; set; }

        
        public Address Address { get; set; }

        public bool isPermanent { get; set; }
    }

    [Serializable]
    public class Address
    {
        [XmlElement("address1")]
        public string address1 { get; set; }

       // public Location location { get; set; }
    }

    [Serializable]

    public class Location
    {
        public string Location1 { get; set; }
    }
}
