using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfWagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());
            string commandLine = Console.ReadLine();

            while (commandLine != "end")
            {
                string[] tokens = commandLine.Split(" ");

                if (tokens.Contains("Add"))
                {
                    int passengersToAdd = int.Parse(tokens[1]);
                    listOfWagons.Add(passengersToAdd);
                }
                else
                {
                    int passengers = int.Parse(tokens[0]);
                    for (int i = 0; i < listOfWagons.Count; i++)
                    {
                        if (passengers + listOfWagons[i] <= wagonCapacity)
                        {
                            listOfWagons[i] += passengers;
                            break;
                        }
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", listOfWagons));
        }
    }
}
