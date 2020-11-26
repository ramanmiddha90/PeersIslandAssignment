using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeerIsland.XMLParser.Extensions
{
    /// <summary>
    /// Exntension methods for Type
    /// </summary>
    public static class XMLTypeExtensions
    {
        //is primitive type
        public static bool IsPrimitive(this Type type)
        {
            return type.IsPrimitive;
        }

        /// <summary>
        /// Check to type is of object type 
        /// </summary>
        /// <param name="type">Input Type</param>
        /// <returns></returns>
        public static bool IsObject(this Type type)
        {
            return !(type.IsPrimitive || type == typeof(string)); 
        }

        /// <summary>
        /// Check serialization type is of collection type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsCollection(this Type type)
        {
            return !(type == typeof(string)) && !(type.IsPrimitive) && type.GetInterfaces().Any(x => x == typeof(IEnumerable));
        }
    }
}
