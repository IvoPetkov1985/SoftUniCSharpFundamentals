using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfGroceries = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string commandLine = Console.ReadLine();

            while (commandLine != "Go Shopping!")
            {
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                switch (currentCommand)
                {
                    case "Urgent":
                        string itemToInsert = tokens[1];

                        if (!listOfGroceries.Contains(itemToInsert))
                        {
                            listOfGroceries.Insert(0, itemToInsert);
                        }
                        break;

                    case "Unnecessary":
                        string unnecessaryProduct = tokens[1];

                        if (listOfGroceries.Contains(unnecessaryProduct))
                        {
                            listOfGroceries.Remove(unnecessaryProduct);
                        }
                        break;

                    case "Correct":
                        string oldItem = tokens[1];
                        string newItem = tokens[2];

                        if (listOfGroceries.Contains(oldItem))
                        {
                            int index = listOfGroceries.IndexOf(oldItem);
                            listOfGroceries.Remove(oldItem);
                            listOfGroceries.Insert(index, newItem);
                        }
                        break;

                    case "Rearrange":
                        string itemToRearrange = tokens[1];

                        if (listOfGroceries.Contains(itemToRearrange))
                        {
                            listOfGroceries.Remove(itemToRearrange);
                            listOfGroceries.Add(itemToRearrange);
                        }
                        break;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", listOfGroceries));
        }
    }
}
