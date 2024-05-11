using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string commandLine = Console.ReadLine();
            int movesCounter = 0;

            while (commandLine != "end")
            {
                int[] indexTokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int firstIndex = indexTokens[0];
                int secondIndex = indexTokens[1];

                movesCounter++;

                if ((firstIndex == secondIndex)
                    || (firstIndex < 0 || firstIndex >= elements.Count)
                    || (secondIndex < 0 || secondIndex >= elements.Count))
                {
                    elements.Insert(elements.Count / 2, $"-{movesCounter}a");
                    elements.Insert(elements.Count / 2, $"-{movesCounter}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (elements.ElementAt(firstIndex) == elements.ElementAt(secondIndex))
                {
                    string value = elements.ElementAt(firstIndex);
                    if (firstIndex < secondIndex)
                    {
                        elements.RemoveAt(secondIndex);
                        elements.RemoveAt(firstIndex);
                    }
                    else
                    {
                        elements.RemoveAt(firstIndex);
                        elements.RemoveAt(secondIndex);
                    }
                    Console.WriteLine($"Congrats! You have found matching elements - {value}!");
                }
                else if (elements.ElementAt(firstIndex) != elements.ElementAt(secondIndex))
                {
                    Console.WriteLine("Try again!");
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {movesCounter} turns!");
                    break;
                }

                commandLine = Console.ReadLine();
            }

            if (elements.Any())
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
        }
    }
}
