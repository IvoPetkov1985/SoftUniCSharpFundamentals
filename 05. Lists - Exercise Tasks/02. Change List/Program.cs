using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Change_List
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

            while (commandsLine != "end")
            {
                string[] tokens = commandsLine.Split(" ");
                string currentCommand = tokens[0];

                switch (currentCommand)
                {
                    case "Delete":
                        int valueToDelete = int.Parse(tokens[1]);
                        numbers.RemoveAll(x => x == valueToDelete);
                        break;
                    case "Insert":
                        int valueToInsert = int.Parse(tokens[1]);
                        int position = int.Parse(tokens[2]);
                        numbers.Insert(position, valueToInsert);
                        break;
                }

                commandsLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
