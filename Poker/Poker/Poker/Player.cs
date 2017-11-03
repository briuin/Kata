using System.Collections.Generic;

namespace Poker
{
    public class Player
    {
        private readonly string _name;
        private readonly List<string> _cards;

        public Player(string name, List<string> cards)
        {
            _name = name;
            _cards = cards;
        }
    }
}