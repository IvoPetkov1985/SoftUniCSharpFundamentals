using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arraysList = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<int> resultList = new List<int>();

            for (int i = 0; i < arraysList.Count; i++)
            {
                int[] currentArray = arraysList[arraysList.Count - 1 - i].Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                foreach (int num in currentArray)
                {
                    resultList.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
