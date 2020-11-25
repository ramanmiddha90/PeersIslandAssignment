using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PeerIsland.XMLParser
{
    public class XMLIntParser : AbstractXMLParser<int>
    {
        public override void ParseXML(XmlWriter xmlWriter, object value, XmlTextWriterSerializer writerContext)
        {
            var valueString = XmlConvert.ToString(Convert.ToInt32(value));

            if (valueString != null)
            {
                xmlWriter.WriteString(valueString);
            }
        }
    }
}
