using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string commandsLine = Console.ReadLine();

            while (commandsLine != "Finish")
            {
                string[] tokens = commandsLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        int valueToAdd = int.Parse(tokens[1]);
                        numbers.Add(valueToAdd);
                        break;

                    case "Remove":
                        int valueToRemove = int.Parse(tokens[1]);
                        numbers.Remove(valueToRemove);
                        break;

                    case "Replace":
                        int valueToReplace = int.Parse(tokens[1]);
                        int newValue = int.Parse(tokens[2]);
                        int indexToReplace = numbers.IndexOf(valueToReplace);

                        if (indexToReplace > -1)
                        {
                            numbers[indexToReplace] = newValue;
                        }
                        break;

                    case "Collapse":
                        int criticalValue = int.Parse(tokens[1]);
                        numbers.RemoveAll(x => x < criticalValue);
                        break;
                }

                commandsLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
