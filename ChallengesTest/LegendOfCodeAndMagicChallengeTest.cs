using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.LegendOfCodeAndMagic;

namespace ChallengesTest
{
    [TestClass]
    public class LegendOfCodeAndMagicChallengeTest
    {
        private LegendOfCodeAndMagicChallenge _legendOfCodeAndMagicChallenge;

        [TestInitialize]
        public void Init()
        {
            _legendOfCodeAndMagicChallenge = new LegendOfCodeAndMagicChallenge();
        }

        [TestMethod]
        public void Test1()
        {
            Assert.IsTrue(true);
        }
    }
}