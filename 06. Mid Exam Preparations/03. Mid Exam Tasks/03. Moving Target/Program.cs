using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "Shoot")
                {
                    int indexToShoot = int.Parse(tokens[1]);
                    int power = int.Parse(tokens[2]);

                    if (indexToShoot >= 0 && indexToShoot < targets.Count)
                    {
                        targets[indexToShoot] -= power;

                        if (targets[indexToShoot] <= 0)
                        {
                            targets.RemoveAt(indexToShoot);
                        }
                    }
                }
                else if (command == "Add")
                {
                    int indexToAdd = int.Parse(tokens[1]);
                    int valueToAdd = int.Parse(tokens[2]);

                    if (indexToAdd >= 0 && indexToAdd < targets.Count)
                    {
                        targets.Insert(indexToAdd, valueToAdd);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command == "Strike")
                {
                    int index = int.Parse(tokens[1]);
                    int radius = int.Parse(tokens[2]);

                    int start = index - radius;
                    int end = index + radius;

                    if (start < 0 || end >= targets.Count)
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    else
                    {
                        targets.RemoveRange(start, radius * 2 + 1);
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
