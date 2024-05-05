using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collectedItems = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string commandLine = Console.ReadLine();

            while (commandLine != "Craft!")
            {
                string[] tokens = commandLine.Split(" - ");
                string command = tokens[0];

                if (command == "Collect")
                {
                    string item = tokens[1];

                    if (!collectedItems.Contains(item))
                    {
                        collectedItems.Add(item);
                    }
                }
                else if (command == "Drop")
                {
                    string itemToDrop = tokens[1];

                    if (collectedItems.Contains(itemToDrop))
                    {
                        collectedItems.Remove(itemToDrop);
                    }
                }
                else if (command == "Combine Items")
                {
                    string itemsToCombine = tokens[1];
                    string[] items = itemsToCombine.Split(":");
                    string oldItem = items[0];
                    string newItem = items[1];

                    if (collectedItems.Contains(oldItem))
                    {
                        int index = collectedItems.IndexOf(oldItem);
                        collectedItems.Insert(index + 1, newItem);
                    }
                }
                else if (command == "Renew")
                {
                    string itemToRenew = tokens[1];

                    if (collectedItems.Contains(itemToRenew))
                    {
                        collectedItems.Remove(itemToRenew);
                        collectedItems.Add(itemToRenew);
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", collectedItems));
        }
    }
}
