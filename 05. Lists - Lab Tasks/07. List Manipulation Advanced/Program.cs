using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            string commandInput = Console.ReadLine();
            bool hasChanges = false;

            while (commandInput != "end")
            {
                string[] tokens = commandInput.Split(" ");
                string command = tokens[0];

                if (command == "Add")
                {
                    int value = int.Parse(tokens[1]);
                    numbers.Add(value);
                    hasChanges = true;
                }
                else if (command == "Remove")
                {
                    int valueToRemove = int.Parse(tokens[1]);
                    numbers.Remove(valueToRemove);
                    hasChanges = true;
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(tokens[1]);
                    numbers.RemoveAt(index);
                    hasChanges = true;
                }
                else if (command == "Insert")
                {
                    int valueToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);
                    numbers.Insert(indexToInsert, valueToInsert);
                    hasChanges = true;
                }
                else if (command == "Contains")
                {
                    int searchedNum = int.Parse(tokens[1]);
                    if (numbers.Contains(searchedNum))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command == "Filter")
                {
                    string condition = tokens[1];
                    int valueToCompare = int.Parse(tokens[2]);

                    switch (condition)
                    {
                        case "<":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < valueToCompare)
                                {
                                    Console.Write($"{numbers[i]} ");
                                }
                            }
                            break;

                        case ">":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > valueToCompare)
                                {
                                    Console.Write($"{numbers[i]} ");
                                }
                            }
                            break;

                        case ">=":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= valueToCompare)
                                {
                                    Console.Write($"{numbers[i]} ");
                                }
                            }
                            break;

                        case "<=":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= valueToCompare)
                                {
                                    Console.Write($"{numbers[i]} ");
                                }
                            }
                            break;
                    }
                    Console.WriteLine();
                }

                commandInput = Console.ReadLine();
            }

            if (hasChanges)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
