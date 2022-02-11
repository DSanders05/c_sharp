using System;

namespace Human
{
    public class Wizard : Human
    {
        //Add unique feature for wizard



        public Wizard(string name, int str, int intel, int dex, int hPoints) : base(name,str,25,dex,50){}

        public override void attack(Human target)
        {
            //wizard attack reduces the target by 5*intellect and heals wizard by the amount of dmg dealt
            int abilityPwr = (Intelligence*5);
            target.health-=abilityPwr;
            this.health+=abilityPwr;
            Console.WriteLine($"{Name} has cast a spell draining {abilityPwr} health from {target.Name} and restoring the damage to himself.");
        }
        public void heal()
        {
            int healAmt = (Intelligence*10);
            this.health+=healAmt;
            Console.WriteLine($"Wizard {Name} has cast a healing spell restoring {healAmt} health.");
        }
    }
}