using System;
using System.Collections.Generic;

namespace hungry_ninjas
{
    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public string name;
        private bool isFull;

        public Ninja()
        {
            this.name=name;
            calorieIntake = 0;
            FoodHistory = null;
            isFull = false;
        }

        public void Eat(Food item)
        {
        }
    }
}