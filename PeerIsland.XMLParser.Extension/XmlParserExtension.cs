using PeerIsland.XMLParser.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeerIsland.XMLParser.Extension
{
    /// <summary>
    /// Class extending XML Parser functionality
    /// </summary>
    public static class XmlParserExtension
    {
        //add new employee in existing XML string
        public static string AddEmploee(this XMLParser xmlParser, Employee employee, string existingXML)
        {
            try
            {
                var employees = xmlParser.DeserializeUsingXMlSerializer<EmployeesCollection>(existingXML);
                employees.Employees.Add(employee);
                return xmlParser.Serialize(employees);
            }
            catch(Exception ex)
            {
                throw;
            }

        }
    }
}
