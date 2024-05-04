using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;

            for (int i = 0; i < numsArray.Length; i++)
            {
                int currentNum = numsArray[i];

                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }
            }

            Console.WriteLine(evenSum);
        }
    }
}
