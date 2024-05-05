using System;
using System.Linq;
using System.Collections.Generic;

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
                string command = tokens[0];

                if (command == "Urgent")
                {
                    string urgentProduct = tokens[1];

                    if (!listOfGroceries.Contains(urgentProduct))
                    {
                        listOfGroceries.Insert(0, urgentProduct);
                    }
                }
                else if (command == "Unnecessary")
                {
                    string productToRemove = tokens[1];

                    if (listOfGroceries.Contains(productToRemove))
                    {
                        listOfGroceries.Remove(productToRemove);
                    }
                }
                else if (command == "Correct")
                {
                    string oldProduct = tokens[1];
                    string newProduct = tokens[2];

                    if (listOfGroceries.Contains(oldProduct))
                    {
                        int index = listOfGroceries.IndexOf(oldProduct);
                        listOfGroceries[index] = newProduct;
                    }
                }
                else if (command == "Rearrange")
                {
                    string productToMove = tokens[1];

                    if (listOfGroceries.Contains(productToMove))
                    {
                        listOfGroceries.Remove(productToMove);
                        listOfGroceries.Add(productToMove);
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", listOfGroceries));
        }
    }
}
