using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PeerIsland.XMLParser
{
    /// <summary>
    /// XMLTextWriter 
    /// </summary>
    internal abstract class AbstractXMLTextWriter
    {
        protected XmlWriter xmlWriter;
        protected XmlWriterSettings xmlWriterSettings;
        internal protected AbstractXMLTextWriter(XmlWriter xmlWriter, XmlWriterSettings xmlWriterSettings)
        {
            this.xmlWriter = xmlWriter;
            this.xmlWriterSettings = xmlWriterSettings;
        }

        internal abstract void WriteXML<T>( T Value);

        internal abstract void WritePropertyTypeName<T>(T propertyType);

        internal abstract void WritePropertyValue<T>( T propertyType);

        internal abstract void WriteNull();

        internal abstract void WriteIndent();

        internal void WriteComment(string comments)
        {
            this.xmlWriter.WriteComment(comments);
        }
    }
}
