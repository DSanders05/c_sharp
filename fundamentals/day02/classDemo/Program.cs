using System;


namespace classDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal liger = new Animal("Liger", "Meat", false, 20, 860);
            Console.WriteLine(liger.species);

            Animal dino = new Animal("Quetzalcoatlus", "omnivore", 20, 405.2);
            Console.WriteLine(dino.isExtinct);
        
            dino.makeNoise();
            liger.makeNoise();

            Mythical phoenix = new Mythical("Phoenix", "Fire", 100000, 120.6, "Egypt", true);

            Console.WriteLine(phoenix.species);

            phoenix.eat();
        }
        
    }
}
