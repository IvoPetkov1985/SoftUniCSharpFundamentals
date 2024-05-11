using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Santa_s_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());

            List<int> houses = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            int position = 0;

            for (int i = 0; i < commandsCount; i++)
            {
                string commandLine = Console.ReadLine();
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                if (currentCommand == "Forward")
                {
                    int steps = int.Parse(tokens[1]);

                    if (position + steps < houses.Count && position + steps >= 0)
                    {
                        position += steps;
                        houses.RemoveAt(position);
                    }
                }
                else if (currentCommand == "Back")
                {
                    int steps = int.Parse(tokens[1]);

                    if (position - steps >= 0 && position - steps < houses.Count)
                    {
                        position -= steps;
                        houses.RemoveAt(position);
                    }
                }
                else if (currentCommand == "Gift")
                {
                    int index = int.Parse(tokens[1]);
                    int number = int.Parse(tokens[2]);

                    if (index >= 0 && index < houses.Count)
                    {
                        houses.Insert(index, number);
                        position = index;
                    }
                }
                else if (currentCommand == "Swap")
                {
                    int firstNumber = int.Parse(tokens[1]);
                    int secondNumber = int.Parse(tokens[2]);

                    int firstIndex = houses.IndexOf(firstNumber);
                    int secondIndex = houses.IndexOf(secondNumber);

                    if (firstIndex != -1 && secondIndex != -1)
                    {
                        int temp = houses[firstIndex];
                        houses[firstIndex] = houses[secondIndex];
                        houses[secondIndex] = temp;
                    }
                }
            }

            Console.WriteLine($"Position: {position}");
            Console.WriteLine(string.Join(", ", houses));
        }
    }
}
