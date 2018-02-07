using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorPay.Indian.Financial.System.Code.Client.Implementation;


namespace RazorPay.Indian.Financial.System.Code.Tests.Tests
{
    [TestClass]
    public class RazorPayIndianFinancialSystemCodeClientUnitTests
    {
        [TestMethod]
        public void ClientShouldThrowArgumentNullExpectionForEmptyStringAsBankCode()
        {
            Assert.ThrowsException<ArgumentNullException>(() => IFSC.Create(string.Empty));
        }

        [TestMethod]
        public void ClientShouldReturnIndianFinancialSystemCodeObjectForValidStringAsBankCode()
        {
            Assert.IsInstanceOfType(IFSC.Create("ABCDEFGC"), typeof(IFSC));
        }

        [TestMethod]
        public void ClientShouldReturnBankDetailsForValidIndianFinancialSystemCode()
        {
            var searchResponse = IFSC.Create("SBIN0021527").Search();
            Assert.IsTrue(searchResponse.IsSuccess);
            Assert.AreEqual("SINDHNOOR RURAL R H COLONY", searchResponse.Bank.Branch);
            Assert.AreEqual("HCOL2SINDHANUMANDALAICHUDT", searchResponse.Bank.Address);
            Assert.AreEqual("8884454887", searchResponse.Bank.Contact);
            Assert.AreEqual("RAICHUR", searchResponse.Bank.City);
            Assert.AreEqual("RAICHUR", searchResponse.Bank.District);
            Assert.AreEqual("KARNATAKA", searchResponse.Bank.State);
            Assert.IsTrue(searchResponse.Bank.IsRTGS);
            Assert.AreEqual("State Bank of India", searchResponse.Bank.Name);
            Assert.AreEqual("State Bank of India", searchResponse.Bank.Name);
            Assert.AreEqual("SBIN", searchResponse.Bank.BankCode);
            Assert.AreEqual("SBIN0021527", searchResponse.Bank.IFSC);
        }
    }
}
