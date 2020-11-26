using System;
using System.Collections.Generic;
using System.Text;

namespace PeerIsland.XMLParser
{
    public static class PeerIslandXMLSerializer
    {
        public static string Serialize<T>(this XMLParser xmlParser,T input)
        {
            return xmlParser.Serialize<T>(input);
        }
        public static object Deserialze<T>(this XMLParser xmlParser, string xmlString)
        {
            return xmlParser.DeserializeUsingXMlSerializer<T>(xmlString);
        }
    }
}
