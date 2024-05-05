using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string commandLine = Console.ReadLine();

            while (commandLine != "end")
            {
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                if (currentCommand == "swap")
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);
                    int tempValue = numbers.ElementAt(firstIndex);
                    numbers[firstIndex] = numbers[secondIndex];
                    numbers[secondIndex] = tempValue;
                }
                else if (currentCommand == "multiply")
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);
                    int currentResult = numbers[firstIndex] * numbers[secondIndex];
                    numbers[firstIndex] = currentResult;
                }
                else if (currentCommand == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
