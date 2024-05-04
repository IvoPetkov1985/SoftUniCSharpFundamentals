using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string commandLine = Console.ReadLine();
                string[] tokens = commandLine.Split(" ");
                string guestName = tokens[0];

                if (!tokens.Contains("not"))
                {
                    if (!guestList.Contains(guestName))
                    {
                        guestList.Add(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                }
                else
                {
                    if (guestList.Contains(guestName))
                    {
                        guestList.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, guestList));
        }
    }
}
