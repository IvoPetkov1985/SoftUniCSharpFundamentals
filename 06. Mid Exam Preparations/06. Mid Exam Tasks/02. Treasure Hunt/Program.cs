﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> treasureChest = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string commandLine = Console.ReadLine();
            bool isSuccessful = true;

            while (commandLine != "Yohoho!")
            {
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                if (currentCommand == "Loot")
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        string currentItem = tokens[i];

                        if (!treasureChest.Contains(currentItem))
                        {
                            treasureChest.Insert(0, currentItem);
                        }
                    }
                }
                else if (currentCommand == "Drop")
                {
                    int indexToDrop = int.Parse(tokens[1]);

                    if (indexToDrop >= 0 && indexToDrop < treasureChest.Count)
                    {
                        string itemToDrop = treasureChest.ElementAt(indexToDrop);
                        treasureChest.RemoveAt(indexToDrop);
                        treasureChest.Add(itemToDrop);
                    }
                }
                else if (currentCommand == "Steal")
                {
                    int count = int.Parse(tokens[1]);

                    if (count < treasureChest.Count)
                    {
                        string stolenItems = string.Empty;

                        for (int i = treasureChest.Count - count; i < treasureChest.Count; i++)
                        {
                            string stolenItem = treasureChest[i];

                            if (i == treasureChest.Count - 1)
                            {
                                stolenItems += stolenItem;
                            }
                            else
                            {
                                stolenItems += stolenItem + ", ";
                            }
                        }

                        treasureChest.RemoveRange(treasureChest.Count - count, count);
                        Console.WriteLine(stolenItems);
                    }
                    else
                    {
                        Console.WriteLine(string.Join(", ", treasureChest));
                        Console.WriteLine("Failed treasure hunt.");
                        isSuccessful = false;
                        break;
                    }
                }

                commandLine = Console.ReadLine();
            }

            if (isSuccessful)
            {
                int sumItems = 0;

                foreach (string item in treasureChest)
                {
                    sumItems += item.Length;
                }

                double averageGain = sumItems / (double)treasureChest.Count;

                Console.WriteLine($"Average treasure gain: {averageGain:F2} pirate credits.");
            }
        }
    }
}
