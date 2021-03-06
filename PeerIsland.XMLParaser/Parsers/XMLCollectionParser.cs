﻿using System;
using System.Collections;
using System.Linq;
using System.Xml;

namespace PeerIsland.XMLParser
{
    internal class XMLCollectionParser : IXMLParser
    {
        public bool CanParse(Type value)
        {
            return value.GetInterfaces().Any(x => x == typeof(IEnumerable));
        }

        public bool CanRead(Type value)
        {
            throw new NotImplementedException();
        }

        public void ParseXML(XmlWriter xmlWriter, object value, XmlTextWriterSerializer writerContext)
        {
          //  xmlWriter.WriteStartElement(value.GetType().);
            //parse collection objects herey
            foreach (var item in (IEnumerable)value)
            {
                if(item==null)
                {
                    writerContext.WriteNull();
                }
                else
                {
                    writerContext.WriteXML(item);
                }

            }
            
        }

        public void ReadXML(XmlReader xmlWriter, object value, XMLTextReaderDeserializer writerContext)
        {
            throw new NotImplementedException();
        }
    }
}
