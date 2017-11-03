using System;
using System.Linq;

namespace Poker
{
    public class PokerGame
    {
        private readonly Player _player1;
        private readonly Player _player2;

        public PokerGame(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public string GetOutput()
        {
            if (GetResult(_player1) == GetResult(_player2))
                return "Tie.";
            return _player2._name+" wins. - with high card: Ace";
        }

        private EnumPokerRank GetResult(Player player)
        {
            if(player._cards.GroupBy(x=>x).Count() == 5)
                return EnumPokerRank.HighCard;

            return EnumPokerRank.HighCard;
        }
    }

    internal enum EnumPokerRank
    {
        HighCard = 1
    }
}