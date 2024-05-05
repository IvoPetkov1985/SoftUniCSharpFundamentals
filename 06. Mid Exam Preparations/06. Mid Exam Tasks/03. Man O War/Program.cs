using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] warship = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int maxHealthCapacity = int.Parse(Console.ReadLine());
            bool isStalemate = true;

            string commandLine = Console.ReadLine();

            while (commandLine != "Retire")
            {
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "Fire")
                {
                    int index = int.Parse(tokens[1]);
                    int damage = int.Parse(tokens[2]);

                    if (index >= 0 && index < warship.Length)
                    {
                        warship[index] -= damage;

                        if (warship[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            isStalemate = false;
                            break;
                        }
                    }
                }
                else if (command == "Defend")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    int damage = int.Parse(tokens[3]);

                    if ((startIndex >= 0 && startIndex < pirateShip.Length)
                        && (endIndex >= 0 && endIndex < pirateShip.Length))
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;

                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                isStalemate = false;
                                break;
                            }
                        }
                    }
                    if (!isStalemate)
                    {
                        break;
                    }
                }
                else if (command == "Repair")
                {
                    int indexToRepair = int.Parse(tokens[1]);
                    int health = int.Parse(tokens[2]);

                    if (indexToRepair >= 0 && indexToRepair < pirateShip.Length)
                    {
                        pirateShip[indexToRepair] += health;

                        if (pirateShip[indexToRepair] > maxHealthCapacity)
                        {
                            pirateShip[indexToRepair] = maxHealthCapacity;
                        }
                    }
                }
                else if (command == "Status")
                {
                    int counter = 0;
                    double threshold = maxHealthCapacity * 0.20;

                    foreach (int section in pirateShip)
                    {
                        if (section < threshold)
                        {
                            counter++;
                        }
                    }

                    Console.WriteLine($"{counter} sections need repair.");
                }

                commandLine = Console.ReadLine();
            }

            if (isStalemate)
            {
                int pirateShipSum = pirateShip.Sum();
                int warshipSum = warship.Sum();

                Console.WriteLine($"Pirate ship status: {pirateShipSum}");
                Console.WriteLine($"Warship status: {warshipSum}");
            }

        }
    }
}
