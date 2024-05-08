using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minerQuantities = new Dictionary<string, int>();

            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!minerQuantities.ContainsKey(resource))
                {
                    minerQuantities[resource] = 0;
                }

                minerQuantities[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> kvp in minerQuantities)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
