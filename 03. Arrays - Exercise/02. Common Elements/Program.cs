﻿using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] secondArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (secondArr[i] == firstArr[j])
                    {
                        Console.Write(firstArr[j] + " ");
                    }
                }
            }
        }
    }
}
