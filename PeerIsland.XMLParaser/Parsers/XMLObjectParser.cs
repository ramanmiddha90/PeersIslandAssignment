using PeerIsland.XMLParser.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml;
namespace PeerIsland.XMLParser
{
    internal class XMLObjectParser : IXMLParser
    {
        public bool CanParse(Type value)
        {
            return !value.IsPrimitive || value == typeof(string);
        }

        public void ParseXML(XmlWriter xmlWriter, object value)
        {
            throw new NotImplementedException();
        }

        public void ParseXML(XmlWriter xmlWriter, object value, XmlTextWriterSerializer writerContext)
        {
            //parse collection process logic here
            if (value == null)
            {
                return;
            }
            //   xmlWriter.WriteStartElement("Employee");
            xmlWriter.WriteStartElement(GetRootElement(value));
            foreach (var property in GetXMLObjectProperties(value.GetType()))
            {
                if(XMLTypeExtensions.IsCollection(property.PropertyType))
                {
                    xmlWriter.WriteStartElement(property.Name);
                    var propValue = GetPropertyValue(property, value);
                    writerContext.WriteXML(propValue);
                    xmlWriter.WriteEndElement();
                }
                else if (XMLTypeExtensions.IsObject(property.PropertyType))
                {
                    var propValue = GetPropertyValue(property, value);
                    writerContext.WriteXML(propValue);
                }
                else
                {
                    writerContext.WritePropertyXML(GetPropertyValue(property, value), property.PropertyType, property.Name);
                }
               
            }
            xmlWriter.WriteEndElement();
        }

        private IEnumerable<PropertyInfo> GetXMLObjectProperties(Type valueType)
        {
            return valueType
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(x => x.GetIndexParameters().Length == 0);
        }

        private object GetPropertyValue(PropertyInfo property, object value)
        {
            return property.GetValue(value);
        }

        private string GetRootElement(Object value)
        {
            return value.GetType().Name;
        }


    }
}
