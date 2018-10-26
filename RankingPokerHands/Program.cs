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
            string format = "\n\t";
            
            Console.WriteLine(format + "Test Group 1");

            Console.WriteLine();
            Console.WriteLine(format + "Expected: Loss");
            Console.WriteLine(format + "Result:" + new PokerHand("2H 3H 4H 5H 6H").CompareWith(new PokerHand("KS AS TS QS JS")));
            Console.WriteLine(format + "---------------------------------------------");
            Console.WriteLine(format + "Expected: Win");
            Console.WriteLine(format + "Result:" + new PokerHand("2H 3H 4H 5H 6H").CompareWith(new PokerHand("AS AD AC AH JD")));
            Console.WriteLine(format + "---------------------------------------------");
            Console.WriteLine(format + "Expected: Win");
            Console.WriteLine(format + "Result:" + new PokerHand("AS AH 2H AD AC").CompareWith(new PokerHand("JS JD JC JH 3D")));
            Console.WriteLine(format + "---------------------------------------------");
            Console.WriteLine(format + "Expected: Loss");
            Console.WriteLine(format + "Result:" + new PokerHand("2S AH 2H AS AC").CompareWith(new PokerHand("JS JD JC JH AD")));
            Console.WriteLine(format + "---------------------------------------------");

            Console.ReadLine();

            Console.WriteLine(format + "Test Group 2");
            Console.WriteLine(format + "Expected: Win");
            Console.WriteLine(format + "Result:" + new PokerHand("2S AH 2H AS AC").CompareWith(new PokerHand("2H 3H 5H 6H 7H")));
            Console.WriteLine(format + "---------------------------------------------");
            Console.WriteLine(format + "Expected: Win");
            Console.WriteLine(format + "Result:" + new PokerHand("AS 3S 4S 8S 2S").CompareWith(new PokerHand("2H 3H 5H 6H 7H")));
            Console.WriteLine(format + "---------------------------------------------");
            Console.WriteLine(format + "Expected: Win");
            Console.WriteLine(format + "Result:" + new PokerHand("2H 3H 5H 6H 7H").CompareWith(new PokerHand("2S 3H 4H 5S 6C")));
            Console.WriteLine(format + "---------------------------------------------");
            Console.WriteLine(format + "Expected: Tie");
            Console.WriteLine(format + "Result:" + new PokerHand("2S 3H 4H 5S 6C").CompareWith(new PokerHand("3D 4C 5H 6H 2S")));
            Console.WriteLine(format + "---------------------------------------------");

            Console.ReadLine();

            Console.WriteLine(format + "Test Group 3");
            Console.WriteLine(format + "Expected: Win");
            Console.WriteLine(format + "Result:" + new PokerHand("2S 3H 4H 5S 6C").CompareWith(new PokerHand("AH AC 5H 6H AS")));
            Console.WriteLine(format + "---------------------------------------------");
            Console.WriteLine(format + "Expected: Loss");
            Console.WriteLine(format + "Result:" + new PokerHand("2S 2H 4H 5S 4C").CompareWith(new PokerHand("AH AC 5H 6H AS")));
            Console.WriteLine(format + "---------------------------------------------");
            Console.WriteLine(format + "Expected: Win");
            Console.WriteLine(format + "Result:" + new PokerHand("2S 2H 4H 5S 4C").CompareWith(new PokerHand("AH AC 5H 6H 7S")));
            Console.WriteLine(format + "---------------------------------------------");
            Console.WriteLine(format + "Expected: Loss");
            Console.WriteLine(format + "Result:" + new PokerHand("6S AD 7H 4S AS").CompareWith(new PokerHand("AH AC 5H 6H 7S")));
            Console.WriteLine(format + "---------------------------------------------");

            Console.ReadLine();

            Console.WriteLine(format + "Test Group 4");
            Console.WriteLine(format + "Expected: Loss");
            Console.WriteLine(format + "Result:" + new PokerHand("2S AH 4H 5S KC").CompareWith(new PokerHand("AH AC 5H 6H 7S")));
            Console.WriteLine(format + "---------------------------------------------");
            Console.WriteLine(format + "Expected: Loss");
            Console.WriteLine(format + "Result:" + new PokerHand("2S 3H 6H 7S 9C").CompareWith(new PokerHand("7H 3C TH 6H 9S")));
            Console.WriteLine(format + "---------------------------------------------");
            Console.WriteLine(format + "Expected: Win");
            Console.WriteLine(format + "Result:" + new PokerHand("4S 5H 6H TS AC").CompareWith(new PokerHand("3S 5H 6H TS AC")));
            Console.WriteLine(format + "---------------------------------------------");
            Console.WriteLine(format + "Expected: Tie");
            Console.WriteLine(format + "Result:" + new PokerHand("2S AH 4H 5S 6C").CompareWith(new PokerHand("AD 4C 5H 6H 2C")));
            Console.WriteLine(format + "---------------------------------------------");

            Console.ReadLine();
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
        string[] cardsArray;
        char[] suits;
        int[] cardValues;

        string classification;

        public int HandValue { get; }

        public PokerHand(string hand)
        {
            this.cardsArray = hand.Split(' ');
            this.suits = Hands.ParseHandSuits(cardsArray);
            this.cardValues = Hands.ParseHandValues(cardsArray);

            this.classification = HandComparator.HandValueCalculator(cardValues, suits);
            Console.WriteLine("\n\t" + classification);
            this.HandValue = Hands.handValues[classification];
        }

        

        public Result CompareWith(PokerHand opponentHand)
        {
            if (this.HandValue > opponentHand.HandValue)
                return Result.Win;

            else if (this.HandValue < opponentHand.HandValue)
                return Result.Loss;

            else
            {
                for(int i = cardValues.Length - 1; i >= 0; i--)
                {
                    if(this.cardValues[i] > opponentHand.cardValues[i])
                    {
                        return Result.Win;
                    }
                    else if(this.cardValues[i] < opponentHand.cardValues[i])
                    {
                        return Result.Loss;
                    }
                }

                return Result.Tie;
            }

        }
    }
    
}
