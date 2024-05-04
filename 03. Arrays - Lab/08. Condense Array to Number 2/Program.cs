using System;
using System.Linq;

namespace _08._Condense_Array_to_Number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arrayOfInts.Length - 1; i++)
            {
                for (int j = 0; j < arrayOfInts.Length - 1 - i; j++)
                {
                    arrayOfInts[j] = arrayOfInts[j] + arrayOfInts[j + 1];
                }
            }

            Console.WriteLine(arrayOfInts[0]);
        }
    }
}
