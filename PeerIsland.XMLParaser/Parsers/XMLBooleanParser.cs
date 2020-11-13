using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PeerIsland.XMLParser.Parsers
{
    public class XMLBooleanParser : AbstractXMLParser<bool>
    {
        public override void ParseXML(XmlWriter xmlWriter, object value)
        {
            var valueString = XmlConvert.ToString(Convert.ToBoolean(value));

            if (valueString != null)
            {
                xmlWriter.WriteString(valueString);
            }
        }
    }
}
