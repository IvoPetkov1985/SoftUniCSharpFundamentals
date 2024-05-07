using System;
using System.Collections.Generic;
using System.Linq;

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

            while (commandLine != "Yohoho!")
            {
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                switch (currentCommand)
                {
                    case "Loot":
                        for (int i = 1; i < tokens.Length; i++)
                        {
                            string currentItem = tokens[i];

                            if (!treasureChest.Contains(currentItem))
                            {
                                treasureChest.Insert(0, currentItem);
                            }
                        }
                        break;

                    case "Drop":
                        int indexToDrop = int.Parse(tokens[1]);

                        if (indexToDrop >= 0 && indexToDrop < treasureChest.Count)
                        {
                            string itemToDrop = treasureChest[indexToDrop];
                            treasureChest.RemoveAt(indexToDrop);
                            treasureChest.Add(itemToDrop);
                        }
                        break;

                    case "Steal":
                        int count = int.Parse(tokens[1]);
                        List<string> stollen = new List<string>();

                        if (count >= treasureChest.Count)
                        {
                            foreach (string item in treasureChest)
                            {
                                stollen.Add(item);
                            }

                            treasureChest.Clear();
                        }
                        else
                        {
                            for (int i = treasureChest.Count - count; i < treasureChest.Count; i++)
                            {
                                string stollenItem = treasureChest[i];
                                stollen.Add(stollenItem);
                            }

                            treasureChest.RemoveRange(treasureChest.Count - count, count);
                        }

                        Console.WriteLine(string.Join(", ", stollen));
                        break;
                }

                commandLine = Console.ReadLine();
            }

            if (treasureChest.Count > 0)
            {
                double averageGain = treasureChest.Select(x => x.Length).Sum() / (double)treasureChest.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:F2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
