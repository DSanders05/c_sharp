using System;

namespace fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            printTo255();
            divisible();
        }

        public static void printTo255()
        {
            for(int i=0;i<256;i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void divisible()
        {
            for(int i=0;i<101;i++)
            {
                if(i%5==0 && i%3==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i%3==0)
                {
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}
