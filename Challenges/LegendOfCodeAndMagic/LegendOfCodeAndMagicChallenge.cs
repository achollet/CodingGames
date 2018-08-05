using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
namespace Challenges.LegendOfCodeAndMagic
{
    class Player
    {
        /**
     * Auto-generated code below aims at helping you parse
     * the standard input according to the problem statement.
     **/
        static void Main(string[] args)
        {
            string[] inputs;

            List<Bot> bots;
            List<Card> cards;

            var turn = 0;
            // game loop
            while (true)
            {
                turn++;
                bots = new List<Bot>();
                cards = new List<Card>();
                for (int i = 0; i < 2; i++)
                {
                    var bot = new Bot(i);

                    inputs = Console.ReadLine().Split(' ');
                    bot.Health = int.Parse(inputs[0]);
                    bot.Mana = int.Parse(inputs[1]);
                    bot.Deck = int.Parse(inputs[2]);
                    bot.Rune = int.Parse(inputs[3]);

                    bots.Add(bot);
                }
                int opponentHand = int.Parse(Console.ReadLine());
                int cardCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < cardCount; i++)
                {
                    var card = new Card();
                    inputs = Console.ReadLine().Split(' ');
                    card.Number = int.Parse(inputs[0]);
                    card.InstanceId = int.Parse(inputs[1]);
                    card.Location = int.Parse(inputs[2]);
                    card.Type = int.Parse(inputs[3]);
                    card.Cost = int.Parse(inputs[4]);
                    card.Attack = int.Parse(inputs[5]);
                    card.Defense = int.Parse(inputs[6]);
                    card.Abilities = inputs[7];
                    card.MyHealthChange = int.Parse(inputs[8]);
                    card.OpponentHealthChange = int.Parse(inputs[9]);
                    card.Draw = int.Parse(inputs[10]);

                    cards.Add(card);
                }

                var action = string.Empty;
                if (turn <= 30)
                {
                    var cardId = SelectCardWithStrongestAttack(cards);

                    if (cardId <= 0 || cardId > 2)
                    {
                        action = "PASS";
                    }
                    else
                    {
                        action = $"PICK {cardId}";
                    }
                }
                else
                {
                    var cardsInMyHand = cards.Where(c => c.Location == 0).ToList();
                    var myCardsOnTheBoard = cards.Where(c => c.Location == 1).ToList();
                    var opponentCardOnTheBoard = cards.Where(c => c.Location == -1).ToList();
                    var myMana = bots[0].Mana;

                    var cardToSummon = 0;

                    if (cardsInMyHand.Count() > 0 && myCardsOnTheBoard.Count() < 6 && myCardsOnTheBoard.Count() < 2)
                    {
                        cardToSummon = SelectCardToSummon(cardsInMyHand, myMana);
                    }

                    var cardToAttackWith = SelectCardWithStrongestAttack(myCardsOnTheBoard);
                    var cardToAttack = SelectCardWithWeakestDefense(opponentCardOnTheBoard);

                    action = BuildingActionReturn(cardToSummon, cardToAttackWith, cardToAttack);
                }

                Console.WriteLine(action);
            }
        }

        private static int SelectCardWithStrongestAttack(List<Card> cards)
        {
            var cardId = 0;
            var attackMax = 0;

            cards.ForEach(c =>
            {
                if (c.Attack > attackMax)
                {
                    attackMax = c.Attack;
                    cardId = c.InstanceId;
                }
            });
            return cardId;
        }

        private static int SelectCardWithWeakestDefense(List<Card> cards)
        {
            var defenseMin = 99;
            var cardId = 0;
            cards.ForEach(c =>
            {
                if (c.Defense < defenseMin)
                {
                    defenseMin = c.Defense;
                    cardId = c.InstanceId;
                }
            });
            return cardId == 0 ? -1 : cardId;
        }

        private static int SelectCardToSummon(List<Card> cards, int manaAvailable)
        {
            var attackMax = 0;
            var cardId = 0;

            cards.ForEach(c =>
            {
                if (c.Attack > attackMax && c.Cost < manaAvailable)
                {
                    attackMax = c.Attack;
                    cardId = c.InstanceId;
                }
            });

            return cardId;
        }

        private static string BuildingActionReturn(int summonCardId, int cardToAttackWith, int cardToAttack)
        {
            var action = new StringBuilder();

            if (summonCardId != 0)
            {
                action.Append($"SUMMON {summonCardId};");
            }

            if (cardToAttackWith != 0)
            {
                action.Append($"ATTACK {cardToAttackWith} {cardToAttack};");
            }

            var actionString = action.ToString();

            if (String.IsNullOrWhiteSpace(actionString) || String.IsNullOrEmpty(actionString))
            {
                actionString = "PASS";
            }
            return actionString;
        }

        public class Bot
        {
            public int Id { get; set; }
            public int Health { get; set; }
            public int Mana { get; set; }
            public int Deck { get; set; }
            public int Rune { get; set; }

            public Bot(int id)
            {
                Id = id;
            }
        }

        public class Card
        {
            public int Number { get; set; }
            public int InstanceId { get; set; }
            public int Location { get; set; }
            public int Type { get; set; }
            public int Cost { get; set; }
            public int Attack { get; set; }
            public int Defense { get; set; }
            public string Abilities { get; set; }
            public int MyHealthChange { get; set; }
            public int OpponentHealthChange { get; set; }
            public int Draw { get; set; }
        }
    }
}