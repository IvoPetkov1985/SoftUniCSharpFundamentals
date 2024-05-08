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
            Dictionary<string, string> softUniUsers = new Dictionary<string, string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string commandLine = Console.ReadLine();
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];
                string username = tokens[1];

                switch (currentCommand)
                {
                    case "register":
                        string licensePlateNumber = tokens[2];

                        if (!softUniUsers.ContainsKey(username))
                        {
                            softUniUsers.Add(username, licensePlateNumber);
                            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        }
                        break;

                    case "unregister":
                        if (!softUniUsers.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            softUniUsers.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        break;
                }
            }

            foreach (var (key, value) in softUniUsers)
            {
                Console.WriteLine($"{key} => {value}");
            }
        }
    }
}
