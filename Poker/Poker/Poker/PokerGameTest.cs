using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker
{
    [TestClass]
    public class PokerGameTest
    {
        [TestMethod]
        public void Test_BlackCard_And_WhiteCard_Are_Same_Will_Output_Tie()
        {
            var player1 = new Player("Black", new List<string>(){"2H","3D","5S","9C","KD"});
            var player2 = new Player("White", new List<string>(){"2H","3D","5S","9C","KD"});

            var game = new PokerGame(player1, player2);

            var actual = game.GetOutput();
            var expected = "Tie.";
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Test_BlackCard_With2H_3D_5S_9C_KD_And_WhiteCard_With2H_3D_5S_9C_AD_Will_Output_White_Win()
        {
            var player1 = new Player("Black", new List<string>() {"2H", "3D", "5S", "9C", "KD"});
            var player2 = new Player("White", new List<string>() {"2H", "3D", "5S", "9C", "AD"});

            var game = new PokerGame(player1, player2);

            var actual = game.GetOutput();
            var expected = "White Wins. - with high card: Ace";
            Assert.AreEqual(expected, actual);
        }
    }
}
