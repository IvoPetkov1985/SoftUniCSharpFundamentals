using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceOfTargets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                int index = int.Parse(tokens[1]);

                switch (command)
                {
                    case "Shoot":
                        int power = int.Parse(tokens[2]);

                        if (index >= 0 && index < sequenceOfTargets.Count)
                        {
                            if (power >= sequenceOfTargets[index])
                            {
                                sequenceOfTargets.RemoveAt(index);
                            }
                            else
                            {
                                sequenceOfTargets[index] -= power;
                            }
                        }
                        break;

                    case "Add":
                        int value = int.Parse(tokens[2]);

                        if (index >= 0 && index < sequenceOfTargets.Count)
                        {
                            sequenceOfTargets.Insert(index, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;

                    case "Strike":
                        int radius = int.Parse(tokens[2]);

                        int startIndex = index - radius;
                        int endIndex = index + radius;

                        if ((startIndex < 0 || startIndex >= sequenceOfTargets.Count)
                            || (endIndex < 0 || endIndex >= sequenceOfTargets.Count))
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        else
                        {
                            sequenceOfTargets.RemoveRange(startIndex, radius * 2 + 1);
                        }
                        break;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", sequenceOfTargets));
        }
    }
}
