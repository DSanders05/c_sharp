using System;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            
        }

        public static void RandomArray(int[] nums)
        {
            int[] randArray = new int[];
            Random rand = new Random();
            for(int val =0;val<11;val++)
            {
                randArray.push(rand.Next(5,25));
            }
            return Console.WriteLine(randArray[9]);
        }
    }
}
