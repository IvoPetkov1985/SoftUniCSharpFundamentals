using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Parking_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 1; i <= numberOfCommands; i++)
            {
                string commandLine = Console.ReadLine();
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];
                string username = tokens[1];

                if (currentCommand == "register")
                {
                    string licensePlateNumber = tokens[2];

                    if (parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
                    }
                    else
                    {
                        parking.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else
                {
                    if (!parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parking.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
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
