using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            sequence = sequence.Where(x => x > sequence.Average())
                .OrderByDescending(x => x)
                .Take(5)
                .ToList();

            if (sequence.Count > 0)
            {
                Console.WriteLine(string.Join(" ", sequence));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
