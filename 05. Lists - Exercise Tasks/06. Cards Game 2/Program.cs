using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayer = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                if (firstPlayer.Count == 0 || secondPlayer.Count == 0)
                {
                    break;
                }

                if (firstPlayer[0] > secondPlayer[0])
                {
                    firstPlayer.Add(secondPlayer[0]);
                    firstPlayer.Add(firstPlayer[0]);
                }
                else if (firstPlayer[0] < secondPlayer[0])
                {
                    secondPlayer.Add(firstPlayer[0]);
                    secondPlayer.Add(secondPlayer[0]);
                }

                firstPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);
            }

            if (firstPlayer.Any())
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
            else if (secondPlayer.Any())
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
        }
    }
}
