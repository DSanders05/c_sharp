using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Player
    {
        public string name;
        public List<Card> hand = new List<Card>();
    
        public Player(string name)
        {
            this.name=name;
        }

        public void draw(Card drawnCard)
        {
            
            hand.Add(drawnCard);
        }

        public void discard(int givenIdx)
        {
            int idx = givenIdx;
            hand.RemoveAt(idx);
        }
    }
}
