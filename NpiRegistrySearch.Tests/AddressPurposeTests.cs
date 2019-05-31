using Microsoft.VisualStudio.TestTools.UnitTesting;
using NpiRegistrySearch.Models;

namespace NpiRegistrySearch.Tests
{
    [TestClass]
    public class AddressPurposeTests
    {
        [TestMethod]
        public void Purposes_With_Same_Value_Should_Be_Equal()
        {
            var addressPurpose1 = AddressPurpose.Location;
            var addressPurpose2 = AddressPurpose.Location;
            Assert.AreEqual(addressPurpose1, addressPurpose2);
        }

        [TestMethod]
        public void Purposes_With_Different_Values_Should_Not_Be_Equal()
        {
            var addressPurpose1 = AddressPurpose.Location;
            var addressPurpose2 = AddressPurpose.Mailing;
            Assert.AreNotEqual(addressPurpose1, addressPurpose2);
        }

        [TestMethod]
        public void Purposes_With_Same_Value_Should_Be_Equal_With_Operator()
        {
            var addressPurpose1 = AddressPurpose.Location;
            var addressPurpose2 = AddressPurpose.Location;
            Assert.IsTrue(addressPurpose1 == addressPurpose2);
        }

        [TestMethod]
        public void Purposes_With_Different_Values_Should_Not_Be_Equal_With_Operator()
        {
            var addressPurpose1 = AddressPurpose.Location;
            var addressPurpose2 = AddressPurpose.Mailing;
            Assert.IsFalse(addressPurpose1 == addressPurpose2);
        }
    }
}
