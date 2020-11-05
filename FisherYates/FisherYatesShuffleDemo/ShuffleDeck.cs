using System;
using System.Collections.Generic;
using System.Text;

namespace FisherYatesShuffleDemo
{
    class ShuffleDeck
    {
        Random randNum = new Random();
        int randomizNum(int i) { return randNum.Next(i); } //The function will return a value that is greater than 0 or last than the given value i (unless i is zero in which it will return 0)
        public void Shuffle(string[] cardDeck)
        {
            for (int i = 0; i < cardDeck.Length; i++)
            {
                int j = randomizNum(i); //method randomizNum will take int i and store it into j
                shuffleArr(cardDeck, i, j); // method takes the array and int i and j to shuffle the deck
            }
        }
        void shuffleArr(string[] cardDeck, int i, int j)
        {
            string temp = cardDeck[i];//temporarily storing the value in i into temp
            cardDeck[i] = cardDeck[j];//taking the randomized value in cardDeck[j] and storing it into cardDeck[i], replacing it.
            cardDeck[j] = temp;//Then taking value of temp, formerly cardDeck[i] before getting replaced, and storing it into what is essentially the next value of the array. 
        }
    }
}
