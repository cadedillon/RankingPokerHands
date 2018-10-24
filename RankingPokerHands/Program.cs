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
            Console.WriteLine(CheckHand.IsFourKind(new int[] { 3, 3, 2, 3, 3 }));
            Console.WriteLine(CheckHand.IsFourKind(new int[] { 2, 3, 3, 3, 3 }));
            Console.WriteLine(CheckHand.IsFourKind(new int[] { 4, 4, 4, 4, 3 }));
            Console.WriteLine(CheckHand.IsFourKind(new int[] { 7, 2, 9, 3, 11 }));
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
