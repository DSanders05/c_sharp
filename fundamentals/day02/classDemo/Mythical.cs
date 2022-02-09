using System;

namespace classDemo
{
    public class Mythical : Animal
    {
        //Add unique features to being a mythical creature
        string origin;
        bool hasMagic;

        public Mythical(string sp, string d, int ls, double wgt, string o, bool mg) : base(sp,d,false,ls,wgt)
        {
            origin = o;
            hasMagic = mg;
        }

        public override void eat()
        {
            //Option 1: we add to the original
            // base.eat();
            // Console.WriteLine("And the gods were pleased");
            //Option 2: we completely rewrite the original
            Console.WriteLine($"The {species} descended upon his prey and feasted");
            this.weight += 0.2;
            Console.WriteLine("And the gods were pleased");
            Console.WriteLine($"{species}'s new weight: {weight}");
        }
    }
}