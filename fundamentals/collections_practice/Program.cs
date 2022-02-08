using System;
using System.Collections.Generic;

namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int[] intArray;
            intArray = new int[] {0,1,2,3,4,5,6,7,8,9};
            string[] stringArray = new string[] {"Tim", "Martin", "Nikki", "Sarah"};
            // Console.WriteLine(stringArray[0]);
            // Console.WriteLine(intArray[3]);

            bool[] truesandfalses = new bool[] {true,false,true,false,true,false,true,false,true};

            List<string> flavors = new List<string>() {"Half-Baked", "Pralines and Cream", "Chocolate", "Vanilla", "Rocky Road"};

            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            Dictionary<string,string> people = new Dictionary<string, string>();
            people.Add(stringArray[0],flavors[0]);
            people.Add(stringArray[1],flavors[1]);
            people.Add(stringArray[2],flavors[2]);
            people.Add(stringArray[3],flavors[3]);

            foreach (KeyValuePair<string,string> person in people)
            {
                Console.WriteLine(person.Key + " - " + person.Value);
            }
        }
        //Create a dictionary that will store both string keys as well as string values

        //Add key/value pairs to this dictionary where:
        //each key is a name from your names array
        //each value is a randomly select a flavor from your flavors list

        //Loop through the dictionary and print out each user's name and their associated ice cream flav


    }
}
