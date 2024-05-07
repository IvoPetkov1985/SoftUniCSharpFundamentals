using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string commandLine = Console.ReadLine();
            int moves = 0;

            while (commandLine != "end")
            {
                int[] indexes = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int index1 = indexes[0];
                int index2 = indexes[1];

                moves++;

                if ((index1 == index2)
                    || (index1 < 0 || index1 >= sequence.Count)
                    || (index2 < 0 || index2 >= sequence.Count))
                {
                    sequence.Insert(sequence.Count / 2, $"-{moves}a");
                    sequence.Insert(sequence.Count / 2, $"-{moves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (sequence[index1] == sequence[index2])
                {
                    string valueToRemove = sequence[index1];
                    sequence.RemoveAll(x => x == valueToRemove);
                    Console.WriteLine($"Congrats! You have found matching elements - {valueToRemove}!");
                }
                else if (sequence[index1] != sequence[index2])
                {
                    Console.WriteLine("Try again!");
                }

                if (sequence.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }

                commandLine = Console.ReadLine();
            }

            if (sequence.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", sequence));
            }
        }
    }
}
