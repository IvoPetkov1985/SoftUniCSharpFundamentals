using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._House_Party_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string commandLine = Console.ReadLine();
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentName = tokens[0];

                if (!tokens.Contains("not"))
                {
                    if (!names.Contains(currentName))
                    {
                        names.Add(currentName);
                    }
                    else
                    {
                        Console.WriteLine($"{currentName} is already in the list!");
                    }
                }
                else
                {
                    if (names.Contains(currentName))
                    {
                        names.Remove(currentName);
                    }
                    else
                    {
                        Console.WriteLine($"{currentName} is not in the list!");
                    }
                }
            }

            names.ForEach(x => Console.WriteLine(x));
        }
    }
}
