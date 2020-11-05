using System;
using System.Collections.Generic;
using System.Text;

namespace FisherYatesShuffleDemo
{
    class CardDeck
    {
        //Created a string Array that will be latered shuffled.
        int value;
        int nextValue;
        string[] cardDeck = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        public string[] returnDeck()
        {
            return cardDeck;
        }

        public int setValueI(string[] carDeck, int i)
        {
            if (carDeck[i] == "K")
                return value = 13;
            if (carDeck[i] == "Q")
                return value = 12;
            if (carDeck[i] == "J")
                return value = 11;
            if (carDeck[i] == "10")
                return value = 10;
            if (carDeck[i] == "9")
                return value = 9;
            if (carDeck[i] == "8")
                return value = 8;
            if (carDeck[i] == "7")
                return value = 7;
            if (carDeck[i] == "6")
                return value = 6;
            if (carDeck[i] == "5")
                return value = 5;
            if (carDeck[i] == "4")
                return value = 4;
            if (carDeck[i] == "3")
                return value = 3;
            if (carDeck[i] == "2")
                return value = 2;
            if (carDeck[i] == "1")
                return value = 1;
            if (carDeck[i] == "A")
                return value = 14;
            return 0;
        }
        public int setValueJ(string[] carDeck, int j)
        {
            if (carDeck[j] == "K")
                return nextValue = 13;
            if (carDeck[j] == "Q")
                return nextValue = 12;
            if (carDeck[j] == "J")
                return nextValue = 11;
            if (carDeck[j] == "10")
                return nextValue = 10;
            if (carDeck[j] == "9")
                return nextValue = 9;
            if (carDeck[j] == "8")
                return nextValue = 8;
            if (carDeck[j] == "7")
                return nextValue = 7;
            if (carDeck[j] == "6")
                return nextValue = 6;
            if (carDeck[j] == "5")
                return nextValue = 5;
            if (carDeck[j] == "4")
                return nextValue = 4;
            if (carDeck[j] == "3")
                return nextValue = 3;
            if (carDeck[j] == "2")
                return nextValue = 2;
            if (carDeck[j] == "1")
                return nextValue = 1;
            if (carDeck[j] == "A")
                return nextValue = 14;
            return 0;
        }
    }
}
