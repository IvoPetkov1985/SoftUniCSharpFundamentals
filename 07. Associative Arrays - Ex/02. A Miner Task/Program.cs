using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, int> minerQuantities = new Dictionary<string, int>();

            while (command != "stop")
            {
                string resource = command;
                int quantity = int.Parse(Console.ReadLine());

                if (!minerQuantities.ContainsKey(resource))
                {
                    minerQuantities[resource] = 0;
                }

                minerQuantities[resource] += quantity;

                command = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> kvp in minerQuantities)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
