using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string commandsLine = Console.ReadLine();
            int counter = 0;

            while (commandsLine != "end")
            {
                int[] tokens = commandsLine.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int firstIndex = tokens[0];
                int secondIndex = tokens[1];
                counter++;

                if ((firstIndex == secondIndex) ||
                    (firstIndex < 0 || firstIndex >= sequence.Count) ||
                    (secondIndex < 0 || secondIndex >= sequence.Count))
                {
                    sequence.Insert(sequence.Count / 2, $"-{counter}a");
                    sequence.Insert(sequence.Count / 2, $"-{counter}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (sequence.ElementAt(firstIndex) == sequence.ElementAt(secondIndex))
                {
                    string element = sequence.ElementAt(firstIndex);
                    sequence.RemoveAll(x => x == element);
                    Console.WriteLine($"Congrats! You have found matching elements - {element}!");
                }
                else if (sequence.ElementAt(firstIndex) != sequence.ElementAt(secondIndex))
                {
                    Console.WriteLine("Try again!");
                }

                if (sequence.Count == 0)
                {
                    Console.WriteLine($"You have won in {counter} turns!");
                    break;
                }

                commandsLine = Console.ReadLine();
            }

            if (commandsLine == "end")
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", sequence));
            }
        }
    }
}
