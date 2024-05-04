using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfArrs = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            List<int> resultList = new List<int>();

            for (int i = 0; i < listOfArrs.Count; i++)
            {
                string currentArrAsString = listOfArrs[i];
                int[] arrayToAdd = currentArrAsString.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < arrayToAdd.Length; j++)
                {
                    int value = arrayToAdd[j];
                    resultList.Add(value);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
