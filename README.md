# RankingPokerHands
This application seeks to compare randomly generated Poker Hands using the rules of Texas Hold 'Em, to determine which hand is higher valued.
It accomplishes this by parsing the value of the cards in the hand out, and then converting them into an integer representation.
It then takes this parsed set and passes it to the CheckHand class, which contains a series of tests that evaluate the hand against
a variety of conditions. The hand is assigned a string classification based on the result of this checking process (such as: "RoyalFlush", "Straight",
"Three of a Kind", etc.) and then assigned an integer value that corresponds with the classification. Finally, the application will compare the 
two integer value representations of the hands, to see which one is the winner!
