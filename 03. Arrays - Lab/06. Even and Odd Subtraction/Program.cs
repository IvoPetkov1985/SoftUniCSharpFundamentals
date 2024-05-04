using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] evenOddNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < evenOddNums.Length; i++)
            {
                int current = evenOddNums[i];

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
