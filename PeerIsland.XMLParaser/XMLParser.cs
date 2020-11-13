using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace PeerIsland.XMLParser
{
    public sealed class XMLParser
    {
        /// <summary>
        /// configuration for XML serializer and deserialzer
        /// </summary>
        private XMLConfiguration xmlConfiguration;

        public XMLParser(XMLConfiguration xmlConfiguration)
        {
            this.xmlConfiguration = xmlConfiguration ?? throw new ArgumentNullException(nameof(xmlConfiguration));
        }

        /// <summary>
        /// Serialze object into XML string
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="input">Object to be serialzed</param>
        /// <returns></returns>
        public string Serialize<T>(T input)
        {
            if (typeof(T) == null)
                throw new ArgumentNullException(nameof(input));

            XmlWriter xmlWriter;
            XmlTextWriter xmlTextWriter;
            var xmlOutputWriter = this.xmlConfiguration.GetXmlOutputWriter();
            var xmlWriterSettings = this.xmlConfiguration.XmlWriterSettings;



            using (xmlWriter = XmlWriter.Create(xmlOutputWriter, xmlWriterSettings))
            {
             
                xmlTextWriter = new XmlTextWriter(xmlWriter, xmlWriterSettings);
                xmlTextWriter.WriteXML(input);
                xmlWriter.Flush();
            }
            return xmlOutputWriter.ToString();
        }

        /// <summary>
        /// Serialze object into XML string
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="input">Object to be serialzed</param>
        /// <returns></returns>
        public T Deserialize<T>(string xml)
        {
            XmlReader xmlReader;
            XMLTextReader xmlTextReader;
            var xmlOutputReader = this.xmlConfiguration.GetXmlOutputReader(xml);

            var xmlReaderSettings = this.xmlConfiguration.XmlReaderSettings ?? throw new ArgumentException(nameof(XmlReaderSettings));

            using (xmlReader = XmlReader.Create(xmlOutputReader, xmlReaderSettings))
            {
                xmlTextReader = new XMLTextReader(xmlReader, xmlReaderSettings);
                xmlReader.Close();

            }
            return (T)new object();
        }

    }
}
