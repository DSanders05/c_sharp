using System;

namespace Human
{
    public class Samurai : Human
    {
        //Add unique feature for Samurai

        public Samurai(string name,int str, int intel, int dex, int hPoints) : base(name, str,intel,dex,200){}
        


        public void meditate()
        {
            //Samurai should have a method called Meditate, which when invoked, heals the Samurai back to full health
            if(this.health<200)
            {
                this.health=200;
            }
            Console.WriteLine($"Samurai {Name} sits and enters a meditative state restoring his health back to full.");
        }

        public override void attack(Human target)
        {
            //override human attack
            //Samurai attack calls the base Attack and reduces the target to 0 if it has less than 50 remaining health points.
            Console.WriteLine($"Samurai {Name} uses his extraordinary skils to deliver a devastating blow.");
            if(target.health>50)
            {
            base.attack(target);
            }
            else if(target.health<50)
            {
                target.health=0;
                Console.WriteLine($"{target.Name}\'s health has been reduced to 0 with a killing blow.");
            };
            
        }
    }
}