﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PeerIsland.XMLParser
{
    public class XMLBooleanParser : AbstractXMLParser<bool>
    {
        public override void ParseXML(XmlWriter xmlWriter, object value, XmlTextWriterSerializer writerContext)
        {
            var valueString = XmlConvert.ToString(Convert.ToBoolean(value));

            if (valueString != null)
            {
                xmlWriter.WriteString(valueString);
            }
        }

        public override void ReadXML(XmlReader xmlWriter, object value, XMLTextReaderDeserializer writerContext)
        {
            throw new NotImplementedException();
        }
    }
}
