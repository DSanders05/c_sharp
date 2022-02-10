using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Card
    {
        public string strVal;
        public string suit;
        public int val;

    public Card(string strValue, string suit, int numVal)
    {
        strVal=strValue;
        this.suit=suit;
        val=numVal;
    }
    }
}

