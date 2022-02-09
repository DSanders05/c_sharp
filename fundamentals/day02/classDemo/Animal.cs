using System;

namespace classDemo
{
    public class Animal
    {
        public string species;
        public string diet;
        public bool isExtinct;
        public int avgLifespan;
        public double weight;
        
        //multiple constructors with C Sharp!
        public Animal(string species, string diet, bool isExt, int avgLife, double Wgt)
        {
            this.species = species;
            this.diet = diet;
            isExtinct = isExt;
            avgLifespan = avgLife;
            weight = Wgt;
        }

        public Animal(string sp, string d, int ls, double wt)
        {
            species = sp;
            diet = d;
            isExtinct = true;
            avgLifespan= ls;
            weight = wt;
        }

        //Methods within classes
        public void makeNoise()
        {
            Console.WriteLine("Insert animal noise here");
        }

        public virtual void eat()
        {
            Console.WriteLine("Munch mucnh");
            this.weight+=0.3;
            Console.WriteLine($"{species} ate some food and now weighs {weight} lbs");
        }
    }
}