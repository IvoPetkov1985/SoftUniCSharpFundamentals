using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_2___Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> treasureChest = Console.ReadLine()
                .Split("|")
                .ToList();

            string commandsLine = Console.ReadLine();

            while (commandsLine != "Yohoho!")
            {
                string[] tokens = commandsLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
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
                    int lootIndex = int.Parse(tokens[1]);

                    if (lootIndex >= 0 && lootIndex < treasureChest.Count)
                    {
                        string currentLoot = treasureChest[lootIndex];
                        treasureChest.RemoveAt(lootIndex);
                        treasureChest.Add(currentLoot);
                    }
                }
                else if (currentCommand == "Steal")
                {
                    int count = int.Parse(tokens[1]);

                    if (count > treasureChest.Count)
                    {
                        count = treasureChest.Count;
                    }

                    string itemsToPrint = string.Empty;

                    for (int i = treasureChest.Count - count; i < treasureChest.Count; i++)
                    {
                        if (i == treasureChest.Count - 1)
                        {
                            itemsToPrint += treasureChest[i];
                        }
                        else
                        {
                            itemsToPrint += treasureChest[i] + ", ";
                        }
                    }

                    Console.WriteLine(itemsToPrint);
                    treasureChest.RemoveRange(treasureChest.Count - count, count);
                }

                commandsLine = Console.ReadLine();
            }

            if (treasureChest.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                int sum = 0;

                for (int i = 0; i < treasureChest.Count; i++)
                {
                    string currentItem = treasureChest[i];
                    sum += currentItem.Length;
                }

                double averagePrice = sum / (treasureChest.Count * 1.0);

                Console.WriteLine($"Average treasure gain: {averagePrice:F2} pirate credits.");
            }
        }
    }
}
