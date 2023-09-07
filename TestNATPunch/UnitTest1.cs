using FNNP;
using Microsoft.VisualStudio.TestPlatform.Common;

namespace TestNATPunch
{
    public class Tests
    {
        [Test]
        public async Task TestGetPublicIp()
        {

            string publicIP = Utilities.GetPublicIp();
            Assert.NotNull(publicIP);
            string publicIp = Utilities.GetPublicIp_Facillitator(
                new Utilities.IPServiceDef() );
            Assert.IsNotEmpty(publicIp);
        }
        [Test]
        public async Task TestGetPublicIp_Facill()
        {
            string publicIp = Utilities.GetPublicIp_Facillitator(
                new Utilities.IPServiceDef() { addr = "192.168.1.64", port = 6080, key = "test" });
            Assert.IsNotEmpty(publicIp);
        }
    }
}
