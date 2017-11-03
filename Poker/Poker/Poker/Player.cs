using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class Player
    {
        public readonly string _name;
        public readonly List<string> _cards;

        public Player(string name, List<string> cards)
        {
            _name = name;
            _cards = SortCardByNumber(cards);
        }

        private List<string> SortCardByNumber(List<string> cards)
        {
            return cards.OrderBy(x => x[0]).ToList();
        }
    }
}