using System;
using System.Collections.Generic;

namespace BASIC13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Print1to255();
            // printSum();
            int[] myArray= new int[]{2,-46,7,-4,25,-7};
            // loopArray(myarray);
            List<int> myList = new List<int>(){3,5,76,2,6};
            // printList(myList);
            dojoReplace(myArray);
        }
            //Basic 13
            public static void Print1to255()
            {
                for(int i=1; i<=255;i++)
                {
                    Console.WriteLine(i);
                }
            }

            public static void PrintOddNums()
            {
                for(int i=1; i<=255;)
                {
                    Console.WriteLine(i);
                }
            }

            public static void printSum()
            {
                int sum = 0;
                for(int i=1; i<=255;i++)
                {
                    Console.WriteLine(i);
                    sum+=i;
                    Console.WriteLine(sum);
                }
            }

            public static void loopArray(int[] numbers)
            {
                for(int i=1; i<=255;i++)
                {
                    Console.WriteLine(i);
                }
            }

            public static void printList(List<int>listArr)
            {
                for(int i=0; i< listArr.Count;i++)
                {
                    Console.WriteLine(listArr[i]);
                }
            }

            public static object[] dojoReplace(int[] arr)
            {
                object[] newArray = new object[arr.Length];
                for(int i=0;i<arr.Length;i++)
                {
                    if(arr[i]<0)
                    {
                        newArray[i] = "dojo";
                    }else{
                        newArray[i] = arr[i];
                    }
                }
                foreach(var j in newArray)
                {
                    Console.WriteLine(j);
                }
                return newArray;
            }
    }
}
