using System;
using System.Linq;

namespace _08._Condense_Array_to_Number_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arrayOfNums.Length - 1; i++)
            {
                int[] condensed = arrayOfNums;

                for (int j = 0; j < condensed.Length - 1; j++)
                {
                    condensed[j] = arrayOfNums[j] + arrayOfNums[j + 1];
                }

                arrayOfNums = condensed;
            }

            Console.WriteLine(arrayOfNums[0]);
        }
    }
}
