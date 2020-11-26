
namespace PeerIsland.XMLParser.Tests
{
    using PeerIsland.XMLParser.Contracts;
    using Xunit;

    public class XMlDeserializerTests
    {
        [Fact]
        public void DeserializeObjects()
        {
            var xml = @"
<Employee>
	<name>raman</name>
	<age>22</age>
	<designation>Developer</designation>
	<Address>
		<address1>add</address1>
	</Address>
	<isPermanent>false</isPermanent>
</Employee>";

            var emp = new Employee()
            {
                age = "22",
                isPermanent = false,
                designation = "Developer",
                name = "raman",
                adress = new Address() { address1 = "add" }
            };
            var xmlConfiguration = new XMLConfiguration();
            var xmlParser = new XMLParser(xmlConfiguration);
            var actual = xmlParser.DeserializeUsingXMlSerializer<Employee>(xml);
            Assert.NotNull(actual);
            Assert.IsType(emp.GetType(), actual);
        }
    }
}
