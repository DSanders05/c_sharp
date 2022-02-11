using System;

namespace Human
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int health;

        public Human(string name, int str, int intel, int dex, int hPoints)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hPoints;
        }

        public Human(string name)
        {
            Name = name;
            Strength=3;
            Intelligence=3;
            Dexterity=3;
            health=100;
        }

        public virtual void attack(Human person)
        {
            health = health-(Strength*5);
            Console.WriteLine($"{Name}\'s health remaining: {health}");
        }
    }
}