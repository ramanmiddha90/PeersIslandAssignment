using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PeerIsland.XMLParser
{
    public class XMLStringParser : AbstractXMLParser<string>
    {
        public override void ParseXML(XmlWriter xmlWriter, object value)
        {
            if (value != null)
            {
                xmlWriter.WriteString(value.ToString());
            }
        }
    }
}
