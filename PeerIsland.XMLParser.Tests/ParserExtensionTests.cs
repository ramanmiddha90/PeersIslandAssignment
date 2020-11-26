
namespace PeerIsland.XMLParser.Tests
{
    using PeerIsland.XMLParser.Contracts;
    using PeerIsland.XMLParser.Extension;
    using Xunit;
    public class ParserExtensionTests
    {
        [Fact]
        public void AddNewEmployeeInEmployeeCollection()
        {
            var xml = @"
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

            var emp = new Employee()
            {
                age = "23",
                isPermanent = false,
                designation = "Developer1",
                name = "raman1",
                Address = new Address() { address1 = "add1" }
            };
            var xmlConfiguration = new XMLConfiguration();
            var xmlParser = new XMLParser(xmlConfiguration);
            var result = xmlParser.AddEmploee(emp, xml);
        }
    }
}
