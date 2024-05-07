using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;

            string[] dungeonRooms = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);

            bool killed = false;

            for (int i = 0; i < dungeonRooms.Length; i++)
            {
                string[] tokens = dungeonRooms[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                int value = int.Parse(tokens[1]);

                switch (command)
                {
                    case "potion":

                        if (health + value > 100)
                        {
                            value = 100 - health;
                            health = 100;
                            Console.WriteLine($"You healed for {value} hp.");
                        }
                        else
                        {
                            health += value;
                            Console.WriteLine($"You healed for {value} hp.");
                        }

                        Console.WriteLine($"Current health: {health} hp.");

                        break;

                    case "chest":

                        Console.WriteLine($"You found {value} bitcoins.");
                        bitcoins += value;

                        break;

                    default:

                        string monster = command;
                        int attack = value;
                        health -= attack;

                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {monster}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {monster}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            killed = true;
                            break;
                        }

                        break;
                }

                if (killed)
                {
                    break;
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
