using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bombDetails = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bombNum = bombDetails[0];
            int power = bombDetails[1];

            while (numbers.Contains(bombNum))
            {
                int bombIndex = numbers.IndexOf(bombNum);
                int start = bombIndex - power;

                if (start < 0)
                {
                    start = 0;
                }

                int end = bombIndex + power;

                if (end >= numbers.Count)
                {
                    end = numbers.Count - 1;
                }

                numbers.RemoveRange(start, end - start + 1);
            }

            int sumElements = numbers.Sum();
            Console.WriteLine(sumElements);
        }
    }
}
