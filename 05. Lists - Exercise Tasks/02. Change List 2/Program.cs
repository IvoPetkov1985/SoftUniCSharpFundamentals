using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();            

            while (true)
            {
                string commandLine = Console.ReadLine();

                if (commandLine == "end")
                {
                    break;
                }

                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                switch (currentCommand)
                {
                    case "Delete":
                        int valueToDelete = int.Parse(tokens[1]);
                        numbers.RemoveAll(x => x == valueToDelete);
                        break;

                    case "Insert":
                        int valueToInsert = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        numbers.Insert(index, valueToInsert);
                        break;
                }                
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
