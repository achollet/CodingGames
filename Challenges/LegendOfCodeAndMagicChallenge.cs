using System;
using System.Collections.Generic;

namespace Challenges.LegendOfCodeAndMagic
{
    #region classes definition
    public class Board
    {
        public int Turn { get; set; }
        public Participant Containder { get; set;}
        public Participant Opponent { get; set;}
        public IEnumerable<Card> Cards { get; set; }
    }

    public class Participant
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int CardsRemaningInDeck { get; set; }
        public int Rune { get; set; }
    }

    public class Card
    {
        public int CardNumber { get; set; }
        public int InstanceId { get; set; }
        public LocationType Location { get; set; }
        public CardType CardType { get; set; }
        public int ManaCost { get; set; }
        public int AttackPoints { get; set; }
        public int DefensePoints { get; set; }
        public string Abilities { get; set; }
        public int MyHealthChange { get; set; }
        public int OpponentHealthChange { get; set; }
        public int CardDraw { get; set; }
    }

<<<<<<< HEAD
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
=======
    public enum LocationType
    {
        Mine = 0,
        OpponentHand = 1,
        OnBoard = -1
    }

    public enum CardType
    {
        Normal = 0
    }
    #endregion

    #region business classes
    public class LegendOfCodeAndMagicChallenge
    {
        

>>>>>>> 8d7eb25b34d7120798f1621478a367d60698b1a6

    }

    #endregion
}