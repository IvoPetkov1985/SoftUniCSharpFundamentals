using System;
using System.Linq;

namespace _07._Equal_Arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int sumNumbers = 0;
            bool areIdentical = true;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    areIdentical = false;
                    break;
                }

                sumNumbers += firstArray[i];
            }

            if (areIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumNumbers}");
            }
        }
    }
}
