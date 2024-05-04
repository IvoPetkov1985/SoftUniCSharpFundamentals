using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string commandsLine = Console.ReadLine();

            while (commandsLine != "End")
            {
                string[] tokens = commandsLine.Split(" ");
                string currentCommand = tokens[0];

                if (currentCommand == "Add")
                {
                    int valueToAdd = int.Parse(tokens[1]);
                    listOfIntegers.Add(valueToAdd);
                }
                else if (currentCommand == "Insert")
                {
                    int valueToInsert = int.Parse(tokens[1]);
                    int position = int.Parse(tokens[2]);

                    if (position < 0 || position >= listOfIntegers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        listOfIntegers.Insert(position, valueToInsert);
                    }
                }
                else if (currentCommand == "Remove")
                {
                    int positionToRemove = int.Parse(tokens[1]);

                    if (positionToRemove < 0 || positionToRemove >= listOfIntegers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        listOfIntegers.RemoveAt(positionToRemove);
                    }
                }
                else if (currentCommand == "Shift")
                {
                    string direction = tokens[1];
                    int count = int.Parse(tokens[2]);

                    if (direction == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int firstNumber = listOfIntegers[0];
                            listOfIntegers.RemoveAt(0);
                            listOfIntegers.Add(firstNumber);
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastNumber = listOfIntegers[listOfIntegers.Count - 1];
                            listOfIntegers.RemoveAt(listOfIntegers.Count - 1);
                            listOfIntegers.Insert(0, lastNumber);
                        }
                    }
                }

                commandsLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", listOfIntegers));
        }
    }
}
