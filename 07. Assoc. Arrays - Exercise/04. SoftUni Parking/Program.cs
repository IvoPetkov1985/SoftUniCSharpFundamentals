using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 1; i <= commandsCount; i++)
            {
                string commandLine = Console.ReadLine();
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];
                string username = tokens[1];

                if (currentCommand == "register")
                {
                    string licensePlate = tokens[2];

                    if (!parking.ContainsKey(username))
                    {
                        parking[username] = licensePlate;
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
                    }
                }
                else if (currentCommand == "unregister")
                {
                    bool isRemoved = parking.Remove(username);

                    if (isRemoved)
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (KeyValuePair<string, string> kvp in parking)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
