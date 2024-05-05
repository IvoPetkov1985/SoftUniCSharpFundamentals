using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            double averageValue = numbers.Average();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentValue = numbers[i];
                if (currentValue > averageValue)
                {
                    result.Add(currentValue);
                }
            }

            result.Sort();
            result.Reverse();

            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }
            else if (result.Count <= 5)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.Write(string.Join(" ", result.Take(5)));
            }
        }
    }
}
