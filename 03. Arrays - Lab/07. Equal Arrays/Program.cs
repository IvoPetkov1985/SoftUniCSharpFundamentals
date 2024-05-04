using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool areEqual = true;
            int sum = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }

                sum += firstArray[i];
            }

            if (areEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
