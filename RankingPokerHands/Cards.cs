using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankingPokerHands
{
    class Cards
    {
        public static Dictionary<char, int> cardValues = new Dictionary<char, int>
        {
            { '2', 1 },
            { '3', 2 },
            { '4', 3 },
            { '5', 4 },
            { '6', 5 },
            { '7', 6 },
            { '8', 7 },
            { '9', 8 },
            { 'T', 9 },
            { 'J', 10 },
            { 'Q', 11 },
            { 'K', 12 },
            { 'A', 13 },
        };

        public enum CardSuits
        {
            S, H, D, C
        };
    }
}
