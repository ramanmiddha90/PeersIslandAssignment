using System;
using System.Collections.Generic;
using System.Text;

namespace PeerIsland.XMLParser
{
    internal static class XMLParserProcessor
    {
        static List<IXMLParser> xmlParsers;

        static XMLParserProcessor()
        {
            xmlParsers = new List<IXMLParser>()
            {
                new XMLIntParser(),
                new XMLStringParser(),
                new XMLCollectionParser(),
                 new XMLObjectParser(),
            };
        }

        /// <summary>
        /// get xml parser based on 
        /// </summary>
        /// <param name="valueType"></param>
        /// <returns></returns>
        public static IXMLParser GetXMLParser(Type valueType)
        {
            IXMLParser xmlParser = null;
            foreach (var parser in xmlParsers)
            {
                if (parser.CanParse(valueType))
                {
                    xmlParser = parser;
                    break;
                }
            }
            return xmlParser;
        }
    }
}
