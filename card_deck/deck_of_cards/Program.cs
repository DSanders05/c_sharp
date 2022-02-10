using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            newDeck.shuffleDeck();
            // newDeck.resetDeck();
            Player Bob = new Player("Bob");
            Card drawnCard = newDeck.dealCard();
            Bob.draw(drawnCard);
        }
        
    }
}
