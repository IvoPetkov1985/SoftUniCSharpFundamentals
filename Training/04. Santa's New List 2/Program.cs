using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Santa_s_New_List_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandLine = Console.ReadLine();

            Dictionary<string, int> children = new Dictionary<string, int>();
            Dictionary<string, int> toys = new Dictionary<string, int>();

            while (commandLine != "END")
            {
                string[] cmdArgs = commandLine.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs.First();

                if (command != "Remove")
                {
                    string name = command;
                    string typeOfToy = cmdArgs[1];
                    int amount = int.Parse(cmdArgs.Last());

                    if (!children.ContainsKey(name))
                    {
                        children.Add(name, amount);
                    }
                    else
                    {
                        children[name] += amount;
                    }

                    if (!toys.ContainsKey(typeOfToy))
                    {
                        toys.Add(typeOfToy, amount);
                    }
                    else
                    {
                        toys[typeOfToy] += amount;
                    }
                }
                else
                {
                    string nameToRemove = cmdArgs.Last();

                    if (children.ContainsKey(nameToRemove))
                    {
                        children.Remove(nameToRemove);
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine("Children:");

            foreach (KeyValuePair<string, int> kvp in children.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            Console.WriteLine("Presents:");

            foreach (KeyValuePair<string, int> kvp in toys)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
