using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace PeerIsland.XMLParser
{
    public sealed class XMLConfiguration
    {
        private XmlReaderSettings readerSettings;
        private XmlWriterSettings writerSettings;
        TextWriter xmlOutputWriter;
        TextReader xmlOutputReader;

        public XMLConfiguration() { }
        /// <summary>
        /// Initialze default reader settings
        /// </summary>
        /// <returns></returns>
        private XmlReaderSettings GetDefaultReaderSettings()
        {
            return new XmlReaderSettings()
            {
                IgnoreComments = true,
                IgnoreProcessingInstructions = true,
                IgnoreWhitespace = true
            };
        }

        /// <summary>
        /// Initialze default writer settings
        /// </summary>
        /// <returns></returns>
        private XmlWriterSettings GetDefaultWriterSettings()
        {
            return new XmlWriterSettings()
            {
                Async = true,
                Indent = true,
                IndentChars = "\t",
                NewLineOnAttributes = true
            };
        }

        /// <summary>
        /// Initialze default writer settings
        /// </summary>
        /// <returns></returns>
        private TextWriter GetDefaultTextWriter()
        {
            return new StringWriter();
        }

        /// <summary>
        /// Initialze default writer settings
        /// </summary>
        /// <returns></returns>
        private TextReader GetDefaultTextReader(string xml)
        {
            return new StringReader(xml);
        }

        /// <summary>
        /// Get XML Reader setttings for reading XML
        /// </summary>
        /// <returns></returns>
        internal TextWriter GetXmlOutputWriter()
        {
            return this.xmlOutputWriter = this.xmlOutputWriter ?? GetDefaultTextWriter();
        }

        /// <summary>
        /// Get XML Reader setttings for reading XML
        /// </summary>
        /// <returns></returns>
        internal TextReader GetXmlOutputReader(string xml)
        {
            return this.xmlOutputReader = this.xmlOutputReader ?? GetDefaultTextReader(xml);
        }

        /// <summary>
        /// Get XML Reader setttings for reading XML
        /// </summary>
        /// <returns></returns>
        public XmlReaderSettings XmlReaderSettings
        {
            get => this.readerSettings ?? GetDefaultReaderSettings();
            set => this.readerSettings = value ;

        }

        /// <summary>
        /// Get XML Reader setttings for reading XML
        /// </summary>
        /// <returns></returns>
        public XmlWriterSettings XmlWriterSettings
        {
            get => this.writerSettings ?? GetDefaultWriterSettings();
            set => this.writerSettings = value;
        }

    }
}
