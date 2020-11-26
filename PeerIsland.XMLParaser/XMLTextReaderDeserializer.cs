using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace PeerIsland.XMLParser
{
    public sealed class XMLTextReaderDeserializer : AbstractXMLTextReader
    {

        /// <summary>
        /// XML deserializer - Deserialze XML int .net object
        /// </summary>
        /// <param name="xmlReader"> XMl Reader</param>
        /// <param name="xmlReaderSettings">Setting to support read XML</param>
        public XMLTextReaderDeserializer(XmlReader xmlReader, XmlReaderSettings xmlReaderSettings) : base(xmlReader, xmlReaderSettings)
        { }
        public override T Deserialize<T>(string xmlString)
        {
            if (xmlString == null)
                throw new ArgumentNullException(nameof(xmlReader));

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                XmlReaderSettings settings = new XmlReaderSettings();

                using (StringReader textReader = new StringReader(xmlString))
                {
                    return (T)serializer.Deserialize(xmlReader);

                }
            }
            catch (Exception ex)
            {
                throw;
            }


        }
    }
}
