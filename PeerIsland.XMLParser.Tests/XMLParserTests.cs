using PeerIsland.XMLParser.Tests.Contracts;
using System;
using System.Collections.Generic;
using Xunit;

namespace PeerIsland.XMLParser.Tests
{
    public class XMLParserTests
    {
        [Fact]
        public void SerialzeCollectionObject()
        {
            var xmlConfiguration = new XMLConfiguration();
            var xmlParser = new XMLParser(xmlConfiguration);
            var employeeCollection = new EmployeesCollection()
            {

                Employees = new List<Employee>()
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
            }
            };

            var serializedString = xmlParser.Serialize<EmployeesCollection>(employeeCollection);

            var expected = @"<?xml version=""1.0"" encoding=""utf-16""?>
<EmployeesCollection>
	<Employees>
		<Employee>
			<name>Mohan</name>
			<age>25</age>
			<designation>Developer</designation>
			<isPermanent>false</isPermanent>
		</Employee>
		<Employee>
			<name>Anitha</name>
			<age>40</age>
			<designation>Senior Developer</designation>
			<isPermanent>false</isPermanent>
		</Employee>
	</Employees>
</EmployeesCollection>";
            Assert.Equal(expected.Trim(), serializedString.Trim());
        }

        [Fact]
        public void SerialzeSingleEmployeeObject()
        {
            var xmlConfiguration = new XMLConfiguration();
            var xmlParser = new XMLParser(xmlConfiguration);

            var serializedString = xmlParser.Serialize<Employee>(new Employee() { age = "22", isPermanent = false, designation = "Developer", name = "raman", adress = new Address() { address1 = "add" } });

            var expected = @"<?xml version=""1.0"" encoding=""utf-16""?>
<Employee>
	<name>raman</name>
	<age>22</age>
	<designation>Developer</designation>
	<Address>
		<address1>add</address1>
	</Address>
	<isPermanent>false</isPermanent>
</Employee>";
            Assert.Equal(expected.Trim(), serializedString.Trim());
        }


        [Fact]
        public void SerialzeSingleEmployeeObjectWithNullObject()
        {
            var xmlConfiguration = new XMLConfiguration();
            var xmlParser = new XMLParser(xmlConfiguration);

            var serializedString = xmlParser.Serialize<Employee>(new Employee() { age = "22", isPermanent = false, designation = "Developer", name = "raman" });

            var expected = @"<?xml version=""1.0"" encoding=""utf-16""?>
<Employee>
	<name>raman</name>
	<age>22</age>
	<designation>Developer</designation>
	<isPermanent>false</isPermanent>
</Employee>";
            Assert.Equal(expected.Trim(), serializedString.Trim());
        }
    }
}
