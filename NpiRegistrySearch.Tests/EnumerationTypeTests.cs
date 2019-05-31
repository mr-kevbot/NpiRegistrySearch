using Microsoft.VisualStudio.TestTools.UnitTesting;
using NpiRegistrySearch.Models;

namespace NpiRegistrySearch.Tests
{
    [TestClass]
    public class EnumerationTypeTests
    {
        [TestMethod]
        public void Enumerations_With_Same_Value_Should_Be_Equal()
        {
            var enumerationType1 = EnumerationType.Individual;
            var enumerationType2 = EnumerationType.Individual;
            Assert.AreEqual(enumerationType1, enumerationType2);
        }

        [TestMethod]
        public void Enumerations_With_Different_Values_Should_Not_Be_Equal()
        {
            var enumerationType1 = EnumerationType.Individual;
            var enumerationType2 = EnumerationType.Organization;
            Assert.AreNotEqual(enumerationType1, enumerationType2);
        }

        [TestMethod]
        public void Enumerations_With_Same_Value_Should_Be_Equal_With_Operator()
        {
            var enumerationType1 = EnumerationType.Individual;
            var enumerationType2 = EnumerationType.Individual;
            Assert.IsTrue(enumerationType1 == enumerationType2);
        }

        [TestMethod]
        public void Enumerations_With_Different_Values_Should_Not_Be_Equal_With_Operator()
        {
            var enumerationType1 = EnumerationType.Individual;
            var enumerationType2 = EnumerationType.Organization;
            Assert.IsFalse(enumerationType1 == enumerationType2);
        }
    }
}
