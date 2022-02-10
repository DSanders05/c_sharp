using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        public int cardTotal;

        public Deck()
        {
            createCardList();
            this.cardTotal = 52;
        }

        public void createCardList()
        {
        List<string> suits = new List<string>(){"Hearts","Clubs","Diamonds","Spades"};

        List<string> stringValues = new List<string>(){"Ace","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Jack","Queen","King"};
        
        int i =0;
        while(i<4)
        {
            int j=1;
            foreach(string value in stringValues)
            {
                cards.Add(new Card(value, suits[i],j));
                j++;
            }
            i++;
        }
    }


        public Card dealCard() //method for dealing top card
        {
            Card cardFromTop = cards[0];
            cards.RemoveAt(0);
            this.cardTotal-=1;
            return cardFromTop; 
        }

        public void shuffleDeck()
        {
            var rand=new Random();
            for(int i=0;i<this.cardTotal;i++)
            {
            int randIdx = rand.Next(this.cardTotal);
            var temp=cards[randIdx];
            cards[randIdx]=cards[i];
            cards[i]=temp;
            }
        }

        public void resetDeck()
        {
            this.cards.Clear();
            createCardList();
        }
    }
}