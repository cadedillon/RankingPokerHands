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

                if (j == cardValues.Length - 1)
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

            //While loop checks to see if the cardValues Array increases linearly to complete the conditions for a straight flush!
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
            for(int i = 0; i < cardValues.Length; i++)
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
            bool pair = false;
            //The for loop will iterate the value of the comparator to the next index of cardValues if 
            //cardCounter int is equal to 3 or 2, the bool switches will flip
            for (int i = 0; i < cardValues.Length; i++)
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
                    pair = true;
                }
            }
            //Only if both booleans are true will the method return true, indicating a full house condition is present
            if (threePair == true && pair == true)
            {
                return true;
            }
            else return false;
        }

        public static bool IsFlush(char[] suits)
        {
            //For loop checks every char in suits array to ensure uniformity in the flush
            for (int i = 0; i < suits.Length; i++)
            {
                //Checks every suit in the hand against the first suit to determine uniformity of suits
                //If there is a different suit in the hand the method will return false
                if (suits[0] != suits[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsStraight(int[] cardValues)
        {
            bool linearSet = false;
            int j = 0;

            //While loop checks to see if the cardValues Array increases linearly to complete the conditions for a straight!
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

        public static bool IsThreeKind(int[] cardValues)
        {
            //Define a comparator that is like temporary storage, so the foreach loop has something to compare against
            int comparator;
            //The for loop will iterate the value of the comparator to the next index of cardValues if 
            //cardCounter int does not reach 3 on that iteration of the foreach loop
            //TODO: See if I can make this more efficient by cardValues.Length / 2
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
                    if (cardCounter == 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool IsTwoPair(int[] cardValues)
        {
            //Define a comparator that is like temporary storage, so the foreach loop has something to compare against
            //Define an integer counter that will iterate everytime a pair condition is detected
            int comparator;
            int pairCount = 0;
            //The for loop will iterate the value of the comparator on each iteration
            //Every time the comparator is equal to the card, the card counter iterates 
            for (int i = 0; i < cardValues.Length; i++)
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
                //If the card counter is equal to two, a pair has been detected and the pairCount iterates
                if (cardCounter == 2)
                {
                    pairCount++;
                }
                
            }
            //A two pair consists of 4 pairs of cards, but only two of them are unique. If pairCount == 4
            //The method is true.
            if (pairCount == 4)
            {
                return true;
            }
            else return false;
        }

        public static bool IsPair(int[] cardValues)
        {
            //Define a comparator that is like temporary storage, so the foreach loop has something to compare against
            //Define an integer counter that will iterate everytime a pair condition is detected
            int comparator;
            int pairCount = 0;
            //The for loop will iterate the value of the comparator on each iteration
            //Every time the comparator is equal to the card, the card counter iterates 
            for (int i = 0; i < cardValues.Length; i++)
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
                //If the card counter is equal to two, a pair has been detected and the pairCount iterates
                if (cardCounter == 2)
                {
                    pairCount++;
                }

            }
            //A pair consists of 2 pairs of cards, but only one unique pair. If pairCount == 2
            //The method is true.
            if (pairCount == 2)
            {
                return true;
            }
            else return false;
        }

        public static int HighCard(int[] cardValues)
        {
            //This method, if no other method returns true
            //Will return the value of the highest card in the hand
            int max = 0;
            //Iterate through cardValues comparing each value to the max variable and
            //if cardValues[i] is higher, assign max to that value
            for(int i = 0; i < cardValues.Length; i++)
            {
                if(cardValues[i] > max)
                {
                    max = cardValues[i];
                }
            }

            return max;
        }
    }
}
