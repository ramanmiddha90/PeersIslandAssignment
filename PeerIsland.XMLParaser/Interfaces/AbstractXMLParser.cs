using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PeerIsland.XMLParser
{
    public abstract class AbstractXMLParser<T> : IXMLParser
    {
        public bool CanParse(Type value)
        {
            return value == typeof(T);
        }

        public abstract void ParseXML(XmlWriter xmlWriter, object value, XmlTextWriterSerializer writerContext);
       
    }
}
