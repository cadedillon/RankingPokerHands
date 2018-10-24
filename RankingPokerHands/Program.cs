using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankingPokerHands
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckHand.IsTwoPair(new int[] { 3, 3, 5, 6, 6 }));
            Console.WriteLine(CheckHand.IsTwoPair(new int[] { 2, 2, 3, 3, 6 }));
            Console.WriteLine(CheckHand.IsTwoPair(new int[] { 7, 11, 11, 12, 12 }));
            Console.WriteLine(CheckHand.IsTwoPair(new int[] { 7, 2, 9, 3, 11 }));
        }
    }

    public enum Result
    {
        Win,
        Loss,
        Tie
    }

    

    public class PokerHand
    {
        public PokerHand(string hand)
        {
            string[] cards = hand.Split(' ');
            char[] suits = Hands.ParseHandSuits(cards);
            int[] cardValues = Hands.ParseHandValues(cards);
        }

        public Result CompareWith(PokerHand hand)
        {
            return Result.Tie;
        }
    }
}
