using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new List<int>();

            int minimumCount = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < minimumCount; i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                for (int i = minimumCount; i < firstList.Count; i++)
                {
                    resultList.Add(firstList[i]);
                }
            }
            else
            {
                for (int i = minimumCount; i < secondList.Count; i++)
                {
                    resultList.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
