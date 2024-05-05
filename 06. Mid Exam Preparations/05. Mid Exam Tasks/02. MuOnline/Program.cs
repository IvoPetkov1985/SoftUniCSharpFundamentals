using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dungeonsRooms = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int health = 100;
            int bitcoins = 0;
            bool killed = false;

            for (int i = 0; i < dungeonsRooms.Length; i++)
            {
                string commandLine = dungeonsRooms[i];
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                int value = int.Parse(tokens[1]);

                if (command == "potion")
                {
                    if (health + value > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                    }
                    else
                    {
                        health += value;
                        Console.WriteLine($"You healed for {value} hp.");
                    }
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                {
                    bitcoins += value;
                    Console.WriteLine($"You found {value} bitcoins.");
                }
                else
                {
                    string monsterName = command;
                    int attackValue = value;

                    if (attackValue < health)
                    {
                        health -= attackValue;
                        Console.WriteLine($"You slayed {monsterName}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monsterName}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        killed = true;
                        break;
                    }
                }
            }

            if (!killed)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
