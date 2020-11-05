using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace FisherYatesShuffleDemo
{
    class HighLow
    {
        CardDeck cDeck;
        Util util = new Util();
        int value = 0, nextValue = 0;
        bool validInput;
        public HighLow(string[] Deck, CardDeck cDeck)
        {
            this.cDeck = cDeck;
            Game(Deck);
        }

        void Game(string[] Deck)
        {
            for (int i = 0; i < Deck.Length - 1; i++)
            {
                validInput = false;
                int j = i + 1;

                value = this.cDeck.setValueI(Deck, i);
                nextValue = this.cDeck.setValueJ(Deck, j);

                PlayerPrompt(Deck, i);
                string playAns = PlayerReponse();

                WriteLine("\n\n" + Deck[j]);

                Result(playAns);
                util.ClearPage();
            }
        }

        void PlayerPrompt(string[] Deck, int i)
        {
            WriteLine(Deck[i]+"\n"
                      + "Will the next card be (1)high or (2)low: ");
        }

        string PlayerReponse()
        {
            while (!validInput)
            {
                string key = ReadLine();
                if (key == "1")
                {
                    validInput = true;
                    return "high";
                }                   
                else if (key == "2")
                {
                    validInput = true;
                    return "low";
                }  
            }
            return String.Empty;
        }

        void Result(string playAns)
        {

            if (playAns == "high")
            {
                if (value < nextValue)
                    WriteLine("Correct!");
                else
                    WriteLine("Incorrect :(");
            }
            else if (playAns == "low")
            {
                if (value > nextValue)
                    WriteLine("Correct!");
                else
                    WriteLine("Incorrect :(");
            }

        }
        
    }
}
