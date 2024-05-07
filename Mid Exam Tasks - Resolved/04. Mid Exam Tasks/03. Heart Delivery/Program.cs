using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighbourhood = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string commandLine = Console.ReadLine();

            int currentIndex = 0;

            while (commandLine != "Love!")
            {
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int length = int.Parse(tokens[1]);

                currentIndex += length;

                if (!(currentIndex >= 0 && currentIndex < neighbourhood.Length))
                {
                    currentIndex = 0;
                }

                if (neighbourhood[currentIndex] > 0)
                {
                    neighbourhood[currentIndex] -= 2;

                    if (neighbourhood[currentIndex] == 0)
                    {
                        Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                    }
                }
                else
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {currentIndex}.");

            if (neighbourhood.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int counter = neighbourhood.Where(x => x > 0).Count();

                Console.WriteLine($"Cupid has failed {counter} places.");
            }
        }
    }
}
