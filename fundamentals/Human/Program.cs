using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human bob = new Human("Bob");

            Human jeff = new Human("Jeff", 5, 10, 2, 120);

            jeff.attack(bob);
            bob.attack(jeff);
        }
    }
}
