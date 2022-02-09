using System;
using System.Collections.Generic;

namespace hungry_ninjas
{
    public class Buffet
    {
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Shrimp", 200, false, false),
                new Food("Mushroom Soup", 150, false, false),
                new Food("Dumplings", 300, false, false),
                new Food("Sweet and Spicy Chicken", 200, true, true),
                new Food("Chocolate Cake", 200, false, true),
                new Food("Steak", 200, false, false),
                new Food("Boiled Eggs", 200, false, false)
            };
        }

        public Food Serve()
        {
            
        }
    }
}