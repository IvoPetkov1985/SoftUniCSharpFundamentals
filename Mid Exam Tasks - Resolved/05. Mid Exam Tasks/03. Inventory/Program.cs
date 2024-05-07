using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> itemsJournal = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string commandLine = Console.ReadLine();

            while (commandLine != "Craft!")
            {
                string[] tokens = commandLine.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "Collect")
                {
                    string itemToAdd = tokens[1];

                    if (!itemsJournal.Contains(itemToAdd))
                    {
                        itemsJournal.Add(itemToAdd);
                    }
                }
                else if (command == "Drop")
                {
                    string itemToRemove = tokens[1];

                    if (itemsJournal.Contains(itemToRemove))
                    {
                        itemsJournal.Remove(itemToRemove);
                    }
                }
                else if (command == "Combine Items")
                {
                    string[] itemsToCombine = tokens[1].Split(":");
                    string oldItem = itemsToCombine[0];
                    string newItem = itemsToCombine[1];
                    int index = itemsJournal.IndexOf(oldItem);

                    if (index > -1)
                    {
                        itemsJournal.Insert(index + 1, newItem);
                    }
                }
                else if (command == "Renew")
                {
                    string itemToRenew = tokens[1];

                    if (itemsJournal.Contains(itemToRenew))
                    {
                        itemsJournal.Remove(itemToRenew);
                        itemsJournal.Add(itemToRenew);
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", itemsJournal));
        }
    }
}
