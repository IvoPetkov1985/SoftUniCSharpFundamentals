using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, double[]> order = new Dictionary<string, double[]>();

            while (input != "buy")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string productName = tokens[0];
                double productPrice = double.Parse(tokens[1]);
                double quantity = int.Parse(tokens[2]);

                if (!order.ContainsKey(productName))
                {
                    order.Add(productName, new double[2]);
                }

                order[productName][0] = productPrice;
                order[productName][1] += quantity;

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, double[]> kvp in order)
            {
                double totalPrice = kvp.Value[0] * kvp.Value[1];

                Console.WriteLine($"{kvp.Key} -> {totalPrice:f2}");
            }
        }
    }
}
