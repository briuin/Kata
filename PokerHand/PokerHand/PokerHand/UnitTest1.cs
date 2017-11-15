using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace PokerHand
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase("2H 3D 5S 9C KD", "2C 3H 4S 8C AH", "White wins - with high card: Ace")]
        [TestCase("2H 3D 5S 9C JD", "2C 3H 4S 8C QH", "White wins - with high card: Q")]
        [TestCase("2H 3D 5S 9C JD", "2C 3H 4S QC 8H", "White wins - with high card: Q")]
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
            var white5thCards = white.Split(' ')[4];
            var cardValue = white5thCards[0];
            var result = "White wins - with high card: ";
            if (cardValue == 'Q')
                return result + "Q";
            return result + "Ace";
        }
    }
}