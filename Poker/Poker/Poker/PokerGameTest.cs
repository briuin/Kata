using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker
{
    [TestClass]
    public class PokerGameTest
    {
        [TestMethod]
        public void Test_BlackCard_And_WhiteCard_Are_Same_Will_Return_Tie()
        {
            var player1 = new Player("Black", new List<string>(){"2H","3D","5S","9C","KD"});
            var player2 = new Player("White", new List<string>(){"2H","3D","5S","9C","KD"});

            var game = new Game(player1, player2);

            var actual = game.GetResult();
            var expected = "Tie.";
            Assert.AreEqual(expected,actual);
        }
    }

    public class Game
    {
        private readonly Player _player1;
        private readonly Player _player2;

        public Game(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public string GetResult()
        {
            throw new NotImplementedException();
        }
    }
}
