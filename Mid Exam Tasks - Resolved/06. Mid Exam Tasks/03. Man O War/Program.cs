using System;
using System.Collections.Generic;
using System.Linq;

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

            int healthCapacity = int.Parse(Console.ReadLine());

            string commandLine = Console.ReadLine();
            bool isPirateShipSunken = false;
            bool isWarshipSunken = false;

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
                            isWarshipSunken = true;
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
                                isPirateShipSunken = true;
                                break;
                            }
                        }

                        if (isPirateShipSunken)
                        {
                            break;
                        }
                    }
                }
                else if (command == "Repair")
                {
                    int index = int.Parse(tokens[1]);
                    int health = int.Parse(tokens[2]);

                    if (index >= 0 && index < pirateShip.Length)
                    {
                        pirateShip[index] += health;

                        if (pirateShip[index] > healthCapacity)
                        {
                            pirateShip[index] = healthCapacity;
                        }
                    }
                }
                else if (command == "Status")
                {
                    int sectionsToBeRapaired = 0;

                    foreach (int section in pirateShip)
                    {
                        double limit = healthCapacity * 0.20;

                        if (section < limit)
                        {
                            sectionsToBeRapaired++;
                        }
                    }

                    Console.WriteLine($"{sectionsToBeRapaired} sections need repair.");
                }

                commandLine = Console.ReadLine();
            }

            if (!isPirateShipSunken && !isWarshipSunken)
            {
                int pirateSum = pirateShip.Sum();
                int warshipSum = warship.Sum();

                Console.WriteLine($"Pirate ship status: {pirateSum}");
                Console.WriteLine($"Warship status: {warshipSum}");
            }
        }
    }
}
