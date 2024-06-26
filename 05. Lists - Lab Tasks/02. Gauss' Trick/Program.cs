﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int currentSum = numbers[i] + numbers[numbers.Count - 1 - i];
                resultList.Add(currentSum);
            }

            if (numbers.Count % 2 == 1)
            {
                resultList.Add(numbers[numbers.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
