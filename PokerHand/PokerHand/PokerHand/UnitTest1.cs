using NUnit.Framework;
using System.Collections.Generic;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace PokerHand
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase("2H 3D 5S 9C KD", "2C 3H 4S 8C AH", "White wins - with high card: Ace")]
        [TestCase("2H 3D 5S 9C JD", "2C 3H 4S 8C QH", "White wins - with high card: Q")]
        [TestCase("2H 3D 5S 9C JD", "2C 3H 4S QC 8H", "White wins - with high card: Q")]
        [TestCase("2C 3H 4S QC 8H", "2H 3D 5S 9C JD", "Black wins - with high card: Q")]
        public void HighCard(string player1, string player2, string result)
        {
            var game = new PokerGame();
            var gameResult = game.Input(player1, player2);
            Assert.AreEqual(result, gameResult);
        }
    }

    public class PokerGame
    {
        public string Input(string black, string white)
        {
            var whiteCards = white.Split(' ');
            List<Card> whiteValues = new List<Card>();
            foreach (var card in whiteCards)
            {
                whiteValues.Add(GetCardValue(card[0]));
            }
            var blackCards = black.Split(' ');
            List<Card> blackValues = new List<Card>();
            foreach (var card in blackCards)
            {
                blackValues.Add(GetCardValue(card[0]));
            }
            //var result = "White wins - with high card: ";
            Card whiteHighCard = GetHighCard(whiteValues);
            Card blackHighCard = GetHighCard(blackValues);

            if (whiteHighCard.Number > blackHighCard.Number)
            {
                return "White wins - with high card: " + whiteHighCard.Name;
            }
            else
            {
                return "Black wins - with high card: " + blackHighCard.Name;
            }
        }

        private Card GetHighCard(List<Card> values)
        {
            Card high = new Card();
            for (int i = 0; i < values.Count; i++)
            {
                if (high.Number < values[i].Number)
                {
                    high = values[i];
                }
            }
            return high;
        }

        private Card GetCardValue(char c)
        {
            string number = "23456789TJQKA";
            var card = new Card();
            card.Number = number.IndexOf(c) + 2;
            return card;
        }
    }

    public class Card
    {
        public int Number { get; set; }
        public string Suit { get; set; }

        public string Name
        {
            get
            {
                if (Number == 12) return "Q";
                if (Number == 14) return "Ace";
                return Number.ToString();
            }
        }
    }
}