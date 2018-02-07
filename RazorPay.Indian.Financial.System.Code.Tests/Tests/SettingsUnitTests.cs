using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorPay.Indian.Financial.System.Code.Client.Configuration;

namespace RazorPay.Indian.Financial.System.Code.Tests.Tests
{
    [TestClass]
    public class SettingsUnitTests
    {
        [TestMethod]
        public void ApplicationConfigurationShouldBeValid() 
        {
            Assert.AreEqual("https://ifsc.razorpay.com", ConfigurationManager.AppSettings["RazorPayEndpoint"]);
        }

        [TestMethod]
        public void SettingsShouldBeValid()
        {
            Assert.IsNotNull(Settings.Configuration.Base);
            Assert.AreEqual(ConfigurationManager.AppSettings["RazorPayEndpoint"], Settings.Configuration.Base);
        }
    }
}