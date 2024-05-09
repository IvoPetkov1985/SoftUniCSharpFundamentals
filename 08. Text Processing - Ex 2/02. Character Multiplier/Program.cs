using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string first = input[0];
            string second = input[1];

            int minLength = Math.Min(first.Length, second.Length);
            int totalSum = 0;

            for (int i = 0; i < minLength; i++)
            {
                totalSum += first[i] * second[i];
            }

            if (first.Length > second.Length)
            {
                for (int i = minLength; i < first.Length; i++)
                {
                    totalSum += first[i];
                }
            }
            else
            {
                for (int i = minLength; i < second.Length; i++)
                {
                    totalSum += second[i];
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
