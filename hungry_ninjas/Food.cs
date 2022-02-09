using System;
using System.Collections.Generic;

namespace hungry_ninjas
{
    public class Food
    {
        public string name;
        public int calories;
        public bool isSpicy;
        public bool isSweet;

        public Food(string name, int calories, bool spicy, bool sweet)
        {
            this.name = name;
            this.calories = calories;
            isSpicy=spicy;
            isSweet=sweet;
        }
    }
}

