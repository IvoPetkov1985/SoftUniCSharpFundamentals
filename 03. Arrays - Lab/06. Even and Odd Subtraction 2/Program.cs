using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < arrayOfInts.Length; i++)
            {
                int current = arrayOfInts[i];

                if (current % 2 == 0)
                {
                    evenSum += current;
                }
                else
                {
                    oddSum += current;
                }
            }

            int result = evenSum - oddSum;
            Console.WriteLine(result);
        }
    }
}
