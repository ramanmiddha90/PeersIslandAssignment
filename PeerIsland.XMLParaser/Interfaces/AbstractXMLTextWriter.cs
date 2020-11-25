using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PeerIsland.XMLParser
{
    /// <summary>
    /// XMLTextWriter 
    /// </summary>
    public abstract class AbstractXMLTextWriter
    {
        protected XmlWriter xmlWriter;
        protected XmlWriterSettings xmlWriterSettings;
        internal protected AbstractXMLTextWriter(XmlWriter xmlWriter, XmlWriterSettings xmlWriterSettings)
        {
            this.xmlWriter = xmlWriter;
            this.xmlWriterSettings = xmlWriterSettings;
        }

        public abstract void WriteXML(object Value);

        public abstract void WritePropertyTypeName<T>(T propertyType);

        public abstract void WritePropertyValue(Type propertyType, object value);

        public abstract void WriteNull();

        public abstract void WriteIndent();

        public void WriteComment(string comments)
        {
            this.xmlWriter.WriteComment(comments);
        }
    }
}
