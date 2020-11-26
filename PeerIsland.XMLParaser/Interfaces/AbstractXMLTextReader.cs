using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PeerIsland.XMLParser
{
    public abstract class AbstractXMLTextReader
    {
        public XmlReader xmlReader;
        public XmlReaderSettings xmlReaderSettings;

        protected AbstractXMLTextReader(XmlReader xmlReader, XmlReaderSettings xmlReaderSettings)
        {
            this.xmlReader = xmlReader;
            this.xmlReaderSettings = xmlReaderSettings;
        }

        public abstract T Deserialize<T>(string xmlString);
    }
}

