﻿using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int sumNumbers = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                Console.Write($"{i} ");
                sumNumbers += i;
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sumNumbers}");
        }
    }
}
