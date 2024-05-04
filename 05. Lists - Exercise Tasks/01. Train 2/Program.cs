using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Contains("Add"))
                {
                    int valueToAdd = int.Parse(tokens[1]);
                    wagons.Add(valueToAdd);
                }
                else
                {
                    int passengers = int.Parse(tokens[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
