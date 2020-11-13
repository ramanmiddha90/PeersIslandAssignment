using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PeerIsland.XMLParser
{
    internal class XmlTextWriter : AbstractXMLTextWriter
    {
        //public XMLConfiguration xmlconfiguration { get; set; }

        internal XmlTextWriter(XmlWriter xmlWriter, XmlWriterSettings xmlWriterSettings) : base(xmlWriter, xmlWriterSettings)
        { }
       

        internal override void WriteXML<T>(T Value)
        {
            if (this.xmlWriter == null)
                throw new ArgumentNullException(nameof(xmlWriter));

            //handle null value
            if (Value == null)
                this.WriteNull();

        }

        internal override void WriteIndent()
        {
          //this.xmlWriter.write
        }

        internal override void WritePropertyTypeName<T>(T propertyType)
        {
            throw new NotImplementedException();
        }

        internal override void WritePropertyValue<T>(T propertyType)
        {
            throw new NotImplementedException();
        }

        internal override void WriteNull()
        {
           
            //for now handling null as new node with name of root
            //find root here
            this.xmlWriter.WriteStartElement("Root");
            this.xmlWriter.WriteEndElement();
        }

    }
}
