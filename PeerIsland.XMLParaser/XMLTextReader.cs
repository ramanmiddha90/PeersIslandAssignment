using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PeerIsland.XMLParser
{
    internal class XMLTextReader : AbstractXMLTextReader
    {
        internal XMLTextReader(XmlReader xmlReader, XmlReaderSettings xmlReaderSettings) : base(xmlReader, xmlReaderSettings) { }

        internal override void ReadXML<T>(T Value)
        {
            throw new NotImplementedException();
        }

        internal override void WriteComment(string comments)
        {
            throw new NotImplementedException();
        }

        internal override void WriteIndent()
        {
            throw new NotImplementedException();
        }

        internal override void WriteNull()
        {
            throw new NotImplementedException();
        }

        internal override void WritePropertyTypeName<T>(T propertyType)
        {
            throw new NotImplementedException();
        }

        internal override void WritePropertyValue<T>(T propertyType)
        {
            throw new NotImplementedException();
        }
    }
}
