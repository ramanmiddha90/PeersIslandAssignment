using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PeerIsland.XMLParser
{
    public interface IXMLParser
    {
        bool CanParse(Type value);

        bool CanRead(Type value);

        void ParseXML(XmlWriter xmlWriter, object value, XmlTextWriterSerializer writerContext);

        void ReadXML(XmlReader xmlWriter, object value, XMLTextReaderDeserializer writerContext);
    }
}
