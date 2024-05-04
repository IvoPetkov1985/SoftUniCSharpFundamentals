using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string commandLine = Console.ReadLine();

            int[] commandNums = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int specialNum = commandNums[0];
            int radius = commandNums[1];

            while (sequence.Contains(specialNum))
            {
                int currentIndex = sequence.IndexOf(specialNum);
                int start = currentIndex - radius;
                if (start < 0)
                {
                    start = 0;
                }

                int end = currentIndex + radius;
                if (end >= sequence.Count)
                {
                    end = sequence.Count - 1;
                }

                sequence.RemoveRange(start, end - start + 1);
            }

            Console.WriteLine(sequence.Sum());
        }
    }
}
