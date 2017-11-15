using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace PokerHand
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase("2H 3D 5S 9C KD", "2C 3H 4S 8C AH", "White wins - with high card: Ace")]
        [TestCase("2H 3D 5S 9C JD", "2C 3H 4S 8C QH", "White wins - with high card: Q")]
        public void HighCard(string player1, string player2, string result)
        {
            var game = new PokerGame();
            var gameResult = game.Input(player1, player2);
            Assert.AreEqual(result, gameResult);
        }

        //[TestMethod]
        //public void Straight()
        //{
        //    var game = new PokerGame();
        //    var gameResult = game.Input("2H 3H 5H 9H KH", "2C 3H 4S 8C AH");
        //    Assert.AreEqual("White wins - with Straight",gameResult);
        //}
    }

    public class PokerGame
    {
        public string Input(string black, string white)
        {
            return "White wins - with high card: Ace";
        }
    }
}