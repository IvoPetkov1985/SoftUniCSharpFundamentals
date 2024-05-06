using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceOfInts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            double averageValue = sequenceOfInts.Average();
            sequenceOfInts.RemoveAll(x => x <= averageValue);
            sequenceOfInts.Sort();
            sequenceOfInts.Reverse();

            if (sequenceOfInts.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", sequenceOfInts.Take(5)));
            }
        }
    }
}
