using System;
using System.Linq;
using System.Collections.Generic;

namespace Challenges.LegendOfCodeAndMagic
{
    public class Player
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int RemainingCardInDeck { get; set; }
        public int Rune { get; set; }
    }
    
    public class Card
    {
        public int Number { get; set; }
        public int InstanceId { get; set; }
        public LocationEnum Location { get; set; }
        public int Type { get; set; }
        public int Cost { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public string Abilities { get; set; }
        public int MyHealthChange { get; set; }
        public int OpponentHealthChange { get; set; }
        public int CardDraw { get; set; }
    }

    public enum LocationEnum
    {
        MyDeck = 0,
        OpponentDeck = 1,
        Board = -1
    }
    
    public class LegendOfCodeAndMagicChallenge
    {
        public int round { get; set; }
        public List<Player>  Players { get; set; }

    }
}