using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Coffee_Lover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffeesList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= commandsCount; i++)
            {
                string commandsLine = Console.ReadLine();
                string[] tokens = commandsLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                if (currentCommand == "Include")
                {
                    string coffeeToAdd = tokens[1];
                    coffeesList.Add(coffeeToAdd);
                }
                else if (currentCommand == "Remove")
                {
                    string direction = tokens[1];
                    int numberOfCoffees = int.Parse(tokens[2]);

                    if (coffeesList.Count >= numberOfCoffees && direction == "first")
                    {
                        coffeesList.RemoveRange(0, numberOfCoffees);
                    }
                    else if (coffeesList.Count >= numberOfCoffees && direction == "last")
                    {
                        coffeesList.RemoveRange(coffeesList.Count - numberOfCoffees, numberOfCoffees);
                    }
                }
                else if (currentCommand == "Prefer")
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);

                    if ((firstIndex >= 0 && firstIndex < coffeesList.Count) && (secondIndex >= 0 && secondIndex < coffeesList.Count))
                    {
                        string firstCoffee = coffeesList[firstIndex];
                        coffeesList[firstIndex] = coffeesList[secondIndex];
                        coffeesList[secondIndex] = firstCoffee;
                    }
                }
                else if (currentCommand == "Reverse")
                {
                    coffeesList.Reverse();
                }
            }

            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffeesList));
        }
    }
}
