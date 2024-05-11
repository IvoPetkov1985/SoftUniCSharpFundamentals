using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targetsSequence = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                string[] tokens = commandLine.Split(" ");
                string command = tokens[0];
                int index = int.Parse(tokens[1]);

                switch (command)
                {
                    case "Shoot":
                        int power = int.Parse(tokens[2]);

                        if (index >= 0 && index < targetsSequence.Count)
                        {
                            targetsSequence[index] -= power;

                            if (targetsSequence[index] <= 0)
                            {
                                targetsSequence.RemoveAt(index);
                            }
                        }
                        break;

                    case "Add":
                        int value = int.Parse(tokens[2]);
                        if (index >= 0 && index < targetsSequence.Count)
                        {
                            targetsSequence.Insert(index, value);
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

                        if (startIndex >= 0 && endIndex < targetsSequence.Count)
                        {
                            targetsSequence.RemoveRange(startIndex, endIndex - startIndex + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targetsSequence));
        }
    }
}
