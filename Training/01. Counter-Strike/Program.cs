﻿using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            short energy = short.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int wonBattles = 0;
            bool hasEnergy = true;

            while (command != "End of battle")
            {
                short distance = short.Parse(command);

                if (distance > energy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    hasEnergy = false;
                    break;
                }

                energy -= distance;
                wonBattles++;

                if (wonBattles % 3 == 0)
                {
                    energy += (short)wonBattles;
                }

                command = Console.ReadLine();
            }

            if (hasEnergy)
            {
                Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
            }
        }
    }
}
