using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeerIsland.XMLParser.Extensions
{
    public static class XMLTypeExtensions
    {
        //is primitive type
        public static bool IsPrimitive(this Type type)
        {
            return type.IsPrimitive;
        }


        public static bool IsObject(this Type type)
        {
            return !(type.IsPrimitive || type == typeof(string)); 
        }


        public static bool IsCollection(this Type type)
        {
            return !(type == typeof(string)) && !(type.IsPrimitive) && type.GetInterfaces().Any(x => x == typeof(IEnumerable));
        }
    }
}
