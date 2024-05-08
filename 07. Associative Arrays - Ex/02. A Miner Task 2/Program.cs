using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }

                resources[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
