using System;
using System.Collections;
using System.Linq;
using System.Xml;
namespace PeerIsland.XMLParser
{
    public class XMLObjectParser : IXMLParser
    {
        public bool CanParse(Type value)
        {
            return value.GetInterfaces().Any(x => x == typeof(IEnumerable));
        }

        public void ParseXML(XmlWriter xmlWriter, object value)
        {
           //parse collection process logic here
        }
    }
}
