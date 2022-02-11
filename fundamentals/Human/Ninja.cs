using System;

namespace Human
{
    public class Ninja : Human
    {

        public Ninja(string name,int str, int intel, int dex, int hPoints) : base(name, str,intel,175,hPoints){}

        public override void attack(Human target)
        {
            int attkPwr=0;
            //attack dmg is 5*dex with 20% 10 extra dmg
            var rand = new Random();
            double percentage = rand.Next(6);
            if(percentage==5)
            {
                attkPwr = (Dexterity*5)+10;
                target.health-=attkPwr;
                Console.WriteLine($"Ninja {Name} has landed a critical strike with increased damage.");
                Console.WriteLine($"{target.Name}\'s health is now {target.health}");
            }
            else
            {
                attkPwr=(Dexterity*5);
                target.health-=attkPwr;
                Console.WriteLine($"Ninja {Name} has landed a strike with normal damage.");
                Console.WriteLine($"{target.Name}\'s health is now {target.health}");
            }
        }

        public void steal(Human target)
        {
            Console.WriteLine($"Ninja {Name} steals health from {target.Name} and uses it to restore his own.");
            target.health-=5;
            this.health+=5;
            Console.WriteLine($"Ninja {Name}\'s health is now {health}.");
        }
    }
}