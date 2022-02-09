using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            RandomArray();
            TossCoin();
            MultiCoinToss(100);
            Names();
        }

        public static void RandomArray()
        {
            var rand = new Random(); //this imports the Random function in a variable
            int maxVal=0;
            int minVal=26;
            int[] randArray = new int[10]; //this declares your array size
            for(int i=0; i<randArray.Length ;i++)
            {
                randArray[i] = rand.Next(5,26); //rand.Next(start point, end point - non inclusive) generates random numbers
                if(maxVal<randArray[i])
                {
                    maxVal=randArray[i];
                }
                if(minVal>randArray[i])
                {
                    minVal=randArray[i];
                }
            }
            Console.WriteLine(minVal);
            Console.WriteLine(maxVal);
            int sum=0;
            foreach(int number in randArray)
            {
                Console.WriteLine(number);
                sum+=number;
            }
                Console.WriteLine(sum);
        }
            public static double TossCoin()
            {
                Console.WriteLine("Tossing a Coin!");
                double headCount = 0.0;
                var rand = new Random();
                int coinSide = rand.Next(2);
                if(coinSide>0)
                {
                    Console.WriteLine("Heads");
                    headCount+=1.0;
                }
                else
                {
                    Console.WriteLine("Tails");
                }
                return headCount;
                //Randomize a coin toos with a result signaling either side of the coin
                //Have the function print either "Heads" or "Tails"
                //Return the result
            }

            public static double MultiCoinToss(double num)
            {
                double newHeadCount = 0.0;
                double winPercentage = 0.0;

                for (int i = 0; i < num; i++)
                {
                    double result =TossCoin();
                    if(result>0)
                    {
                        newHeadCount+=1;
                    }
                    Console.WriteLine(newHeadCount);
                }

                winPercentage = 100*(newHeadCount/num);
                Console.WriteLine($"Win Percentage: %{winPercentage}");

                return winPercentage;
            }

            public static List<string> Names()
            {
                var rand = new Random();
                List<string> nameList = new List<string>();
                nameList.Add("Blake");
                nameList.Add("Drake");
                nameList.Add("Kyle");
                nameList.Add("Wesley");
                nameList.Add("Bruce");
                nameList.Add("Bane");

                foreach(string name in nameList)
                {
                    Console.WriteLine($" {name}");
                }

                int listCount = nameList.Count;
                while(listCount>1)
                {
                    listCount--;
                    int randIdx = rand.Next(listCount);
                    string temp=nameList[randIdx];
                    nameList[randIdx]=nameList[listCount];
                    nameList[listCount]=temp;
                }
                Console.WriteLine(" New List:");
                
                foreach(string name in nameList)
                {
                    Console.Write($" {name}");
                }
                

                return nameList;
            }
    }
}
