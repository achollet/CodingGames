using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.LegendOfCodeAndMagic;
using System.Collections.Generic;

namespace ChallengesTest
{
    [TestClass]
    public class LegendOfCodeAndMagicChallengeTest
    {
        private LegendOfCodeAndMagicChallenge _legendOfCodeAndMagicChallenge;
        private IEnumerable<Card> _boardDeck;

        [TestInitialize]
        public void Init()
        {
            _legendOfCodeAndMagicChallenge = new LegendOfCodeAndMagicChallenge();
            _boardDeck = new List<Card>
            {
                new Card{ CardNumber = 0, AttackPoints = 2},
                new Card{ CardNumber = 1, AttackPoints = 5},
                new Card{ CardNumber = 2, AttackPoints = 9},
            };
        }

        [TestMethod]
        public void PickCardFromBoardDeck()
        {
            var result = _legendOfCodeAndMagicChallenge.PickCardFromBoardDeck(_boardDeck);
            var expected = "PICK 2";

            Assert.AreEqual(expected, result);
        }
    }
}