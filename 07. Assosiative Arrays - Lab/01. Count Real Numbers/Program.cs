using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] realNumsArr = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> numCounts = new SortedDictionary<double, int>();

            foreach (double realNum in realNumsArr)
            {
                if (!numCounts.ContainsKey(realNum))
                {
                    numCounts.Add(realNum, 0);
                }

                numCounts[realNum]++;
            }

            foreach (var (key, value) in numCounts)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
