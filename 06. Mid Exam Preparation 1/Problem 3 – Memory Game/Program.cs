using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_3___Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequenceOfElements = Console.ReadLine()
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

                if (firstIndex == secondIndex)
                {
                    sequenceOfElements.Insert(sequenceOfElements.Count / 2, $"-{counter}a");
                    sequenceOfElements.Insert(sequenceOfElements.Count / 2, $"-{counter}a");

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if ((firstIndex < 0 || firstIndex >= sequenceOfElements.Count) ||
                    (secondIndex < 0 || secondIndex >= sequenceOfElements.Count))
                {
                    sequenceOfElements.Insert(sequenceOfElements.Count / 2, $"-{counter}a");
                    sequenceOfElements.Insert(sequenceOfElements.Count / 2, $"-{counter}a");

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (sequenceOfElements.ElementAt(firstIndex) == sequenceOfElements.ElementAt(secondIndex))
                {
                    string currentElement = sequenceOfElements.ElementAt(firstIndex);
                    sequenceOfElements.RemoveAll(x => x == currentElement);

                    Console.WriteLine($"Congrats! You have found matching elements - {currentElement}!");
                }
                else if (sequenceOfElements.ElementAt(firstIndex) != sequenceOfElements.ElementAt(secondIndex))
                {
                    Console.WriteLine("Try again!");
                }

                if (sequenceOfElements.Count == 0)
                {
                    Console.WriteLine($"You have won in {counter} turns!");
                    break;
                }

                commandsLine = Console.ReadLine();
            }

            if (commandsLine == "end")
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", sequenceOfElements));
            }
        }
    }
}
