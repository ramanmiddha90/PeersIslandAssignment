using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PeerIsland.XMLParser
{
    public class XmlTextWriterSerializer : AbstractXMLTextWriter
    {
        //public XMLConfiguration xmlconfiguration { get; set; }

        public XmlTextWriterSerializer(XmlWriter xmlWriter, XmlWriterSettings xmlWriterSettings) : base(xmlWriter, xmlWriterSettings)
        { }
       

        public override void WriteXML(object Value)
        {
            if (this.xmlWriter == null)
                throw new ArgumentNullException(nameof(xmlWriter));

            //handle null value
            if (Value == null)
            {
                this.WriteNull();
                return;
            }


            var IXMLParser = XMLParserProcessor.GetXMLParser(Value.GetType());
            IXMLParser.ParseXML(xmlWriter, Value,this);
        }

        public void WritePropertyXML(object value,Type valueType,string propertyName)
        {
            xmlWriter.WriteStartElement(propertyName);

            var IXMLParser = XMLParserProcessor.GetXMLParser(valueType);
            IXMLParser.ParseXML(xmlWriter, value, this);
            xmlWriter.WriteEndElement();
        }

        public override void WriteIndent()
        {
          //this.xmlWriter.write
        }

        public override void WritePropertyTypeName<T>(T propertyType)
        {
            throw new NotImplementedException();
        }

        public override void WritePropertyValue(Type propertyType,object value)
        {
            throw new NotImplementedException();
        }

        public override void WriteNull()
        {
           
            ////for now handling null as new node with name of root
            ////find root here
            //this.xmlWriter.WriteStartElement("");
            //this.xmlWriter.WriteEndElement();
        }

    }
}
