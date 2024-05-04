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

            while (commandInput != "end")
            {
                string[] tokens = commandInput.Split(" ");
                string command = tokens[0];

                if (command == "Add")
                {
                    int value = int.Parse(tokens[1]);
                    numbers.Add(value);
                }
                else if (command == "Remove")
                {
                    int valueToRemove = int.Parse(tokens[1]);
                    numbers.Remove(valueToRemove);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(tokens[1]);
                    numbers.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    int valueToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);
                    numbers.Insert(indexToInsert, valueToInsert);
                }

                commandInput = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
