using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankingPokerHands
{
    public class CheckHand
    {
        public static bool IsRoyalFlush(int[] cardValues, char[] suits)
        {
            bool linearSet = false;
            int j = 0;
            
            //For loop checks every char in suits array to ensure uniformity in the royal flush
            for(int i = 0; i < suits.Length; i++)
            {
                if (suits[0] != suits[i])
                {
                    return false;
                }
            }
            
            //While loop checks to see if the cardValues Array is comprised of a 'T' (converted to its int value for easier comparison)
            //and increases linearly to complete the conditions for a royal flush!
            while(linearSet != true)
            { 
                if (cardValues[0] == 9 && cardValues[j] == cardValues[j + 1] - 1)
                {
                   j++;
                }
                else
                {
                    break;
                }

                if(j == cardValues.Length - 1)
                {
                    return true;
                }
                    
            }

            return false;

        }

        public static bool IsStraightFlush(int[] cardValues, char[] suits)
        {
            bool linearSet = false;
            int j = 0;

            //For loop checks every char in suits array to ensure uniformity in the flush
            for (int i = 0; i < suits.Length; i++)
            {
                if (suits[0] != suits[i])
                {
                    return false;
                }
            }

            //While loop checks to see if the cardValues Array increases linearly to complete the conditions for a flush!
            while (linearSet != true)
            {
                if (cardValues[j] == cardValues[j + 1] - 1)
                {
                    j++;
                }
                else
                {
                    break;
                }

                if (j == cardValues.Length - 1)
                {
                    return true;
                }

            }

            return false;
        }

        public static bool IsFourKind(int[] cardValues)
        {
            //Define a comparator that is like temporary storage, so the foreach loop has something to compare against
            int comparator;
            //The for loop will iterate the value of the comparator to the next index of cardValues if 
            //cardCounter int does not reach 4 on that iteration of the foreach loop
            //TODO: See if I can make this more efficient
            for(int i = 0; i < cardValues.Length - 1; i++)
            {
                int cardCounter = 0;
                comparator = cardValues[i];
                foreach(int card in cardValues)
                {
                    if(comparator == card)
                    {
                        cardCounter++;
                    }
                    if(cardCounter == 4)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool IsFullHouse(int[] cardValues)
        {
            //Define a comparator that is like temporary storage, so the foreach loop has something to compare against
            //Define a boolean switch that will flip to "True" if the foreach loop detects a three of a kind or a pair condition
            int comparator;
            bool threePair = false;
            bool twoPair = false;
            //The for loop will iterate the value of the comparator to the next index of cardValues if 
            //cardCounter int is equal to 3 or 2, the bool switches will flip
            for (int i = 0; i < cardValues.Length - 1; i++)
            {
                int cardCounter = 0;
                comparator = cardValues[i];
                foreach (int card in cardValues)
                {
                    if (comparator == card)
                    {
                        cardCounter++;
                    }
                    
                }

                if (cardCounter == 3)
                {
                    threePair = true;
                }
                else if (cardCounter == 2)
                {
                    twoPair = true;
                }
            }
            //Only if both booleans are true will the method return true, indicating a full house condition is present
            if (threePair == true && twoPair == true)
            {
                return true;
            }
            else return false;
        }
    

        //public static bool IsFlush(string[] hand)
        //{

        //}

        //public static bool IsStraight(string[] hand)
        //{

        //}

        //public static bool IsThreeKind(string[] hand)
        //{

        //}

        //public static bool IsTwoPair(string[] hand)
        //{

        //}

        //public static bool IsPair(string[] hand)
        //{

        //}

        //public static int HighCard(string[] hand)
        //{

        //}
    }
}
