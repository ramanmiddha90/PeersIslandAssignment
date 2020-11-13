using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PeerIsland.XMLParser
{
    internal abstract class AbstractXMLTextReader
    {
        protected XmlReader xmlReader;
        protected XmlReaderSettings xmlReaderSettings;

        internal protected AbstractXMLTextReader(XmlReader xmlReader, XmlReaderSettings xmlReaderSettings)
        {
            this.xmlReader = xmlReader;
            this.xmlReaderSettings = xmlReaderSettings;
        }

        internal abstract void ReadXML<T>(T Value);

        internal abstract void WritePropertyTypeName<T>(T propertyType);

        internal abstract void WritePropertyValue<T>(T propertyType);

        internal abstract void WriteNull();

        internal abstract void WriteIndent();

        internal abstract void WriteComment(string comments);
    }
}

