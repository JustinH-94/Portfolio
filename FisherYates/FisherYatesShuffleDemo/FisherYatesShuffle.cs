using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Windows.Input;
namespace FisherYatesShuffleDemo
{
    class FisherYatesShuffle
    {
        CardDeck deck = new CardDeck();
        ShuffleDeck shuffle = new ShuffleDeck();
        HighLow hiLo;
        string[] cardDeck;
        //These values are for setting the values of the card for the high/low game

        //randNum will be used to setting the randomizer of the deck
        
        public FisherYatesShuffle()
        {
            setDeck();
            hiLo = new HighLow(cardDeck, deck);
        }

        void getCards()=>cardDeck = deck.returnDeck();

        void setDeck()
        {
            getCards();
            shuffle.Shuffle(cardDeck);
        }
    }
}
