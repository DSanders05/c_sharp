using System;

namespace Human
{
    public class Human
    {
        public string name;
        public int strength;
        public int intelligence;
        public int dexterity;
        public int health;



        public Human(string name, int str, int intel, int dex, int hPoints)
        {
            this.name = name;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hPoints;
        }

        public Human(string name)
        {
            this.name = name;
            strength=3;
            intelligence=3;
            dexterity=3;
            health=100;
        }

        public void attack(object person)
        {
            health = health-(strength*5);
            Console.WriteLine($"{name}\'s health remaining: {health}");
        }
    }
}