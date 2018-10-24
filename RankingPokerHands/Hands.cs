using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankingPokerHands
{
    public class Hands
    {
        //This dictionary will be the final determination for the value of the hand.
        public static Dictionary<string, int> handValues = new Dictionary<string, int>
        {
          { "High Card", 100 },
          { "Pair", 200 },
          { "Two Pairs", 300 },
          { "Three of a Kind", 400 },
          { "Straight", 500 },
          { "Flush", 600 },
          { "Full House", 700 },
          { "Four of a Kind", 800 },
          { "Straight Flush", 900 },
          { "Royal FLush", 1000 },

        };

        public static int[] ParseHandValues(string[] hand)
        {
            int[] cardVal = new int[hand.Length];
            //iterate through the hand string array. Write the value of the card to cardVal[i], write the suit of the card to suit[i]
            for (int i = 0; i < hand.Length; i++)
            {
                char[] card = hand[i].ToCharArray();
                cardVal[i] = Cards.cardValues[card[0]];
                Console.WriteLine(cardVal[i]);
            }

            //Sort the cardVal array in acending order to make comparison easier
            Array.Sort(cardVal);
            return cardVal;
        }

        public static char[] ParseHandSuits(string[] hand)
        {
            char[] suit = new char[hand.Length];
            for (int i = 0; i < hand.Length; i++)
            {
                char[] card = hand[i].ToCharArray();
                suit[i] = card[1];
                Console.WriteLine(suit[i]);
            }

            return suit;
        }
    }
}
