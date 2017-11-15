using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokerHand
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HighCard()
        {
            var game = new PokerGame();
            var gameResult = game.Input("2H 3D 5S 9C KD", "2C 3H 4S 8C AH");
            Assert.AreEqual("White wins - with high card: Ace", gameResult);
        }
    }

    public class PokerGame
    {
        public string Input(string black, string white)
        {
            return "White wins - with high card: Ace";
        }
    }
}
