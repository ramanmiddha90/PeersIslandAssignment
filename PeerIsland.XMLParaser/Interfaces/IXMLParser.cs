﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PeerIsland.XMLParser
{
    interface IXMLParser
    {
        bool CanParse(Type value);
        void ParseXML(XmlWriter xmlWriter, object value);
    }
}