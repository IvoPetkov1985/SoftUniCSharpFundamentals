using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            SortedDictionary<int, int> numsCounter = new SortedDictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!numsCounter.ContainsKey(numbers[i]))
                {
                    numsCounter.Add(numbers[i], 1);
                }
                else
                {
                    numsCounter[numbers[i]]++;
                }
            }

            foreach (KeyValuePair<int, int> kvp in numsCounter)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
