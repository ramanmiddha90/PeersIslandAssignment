using PeerIsland.XMLParser.Tests.Contracts;
using System;
using System.Collections.Generic;
using Xunit;

namespace PeerIsland.XMLParser.Tests
{
    public class XMLParserTests
    {
        [Fact]
        public void SerialzeObject()
        {
            var xmlConfiguration = new XMLConfiguration();
            var xmlParser = new XMLParser(xmlConfiguration);

            var employees = new List<Employee>()
            {
                new Employee()
                {
                    name="Mohan",
                    age="25",
                    designation="Developer"
                },
                new Employee()
                {
                     name="Anitha",
                    age="40",
                    designation="Senior Developer"
                }
            };

            var serializedString = xmlParser.Serialize<List<Employee>>(employees);

            var expected = @"
                            <employees>
                            <employee>
                            <name>Mohan</name> <age>25</age> <designation>Developer</designation> </employee> <employee>
                            <name>Anitha</name> <age>40</age> <designation>Senior Developer</designation> </employee> </employees>";
            Assert.Equal(expected.Trim(), serializedString.Trim());
        }

        [Fact]
        public void SerialzeObjecWithNullValue()
        {
            var xmlConfiguration = new XMLConfiguration();
            var xmlParser = new XMLParser(xmlConfiguration);

            var serializedString = xmlParser.Serialize<List<Employee>>(null);

            var expected = @"<Root/>";
            Assert.Equal(expected.Trim(), serializedString.Trim());
        }
    }
}
