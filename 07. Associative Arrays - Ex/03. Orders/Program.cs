using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();

            while (inputLine != "buy")
            {
                string[] tokens = inputLine.Split(" ");
                string product = tokens[0];
                double price = double.Parse(tokens[1]);
                double quantity = double.Parse(tokens[2]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, new double[2]);
                }

                products[product][0] = price;
                products[product][1] += quantity;

                inputLine = Console.ReadLine();
            }

            foreach (var kvp in products)
            {
                double totalPrice = kvp.Value[0] * kvp.Value[1];
                Console.WriteLine($"{kvp.Key} -> {totalPrice:F2}");
            }
        }
    }
}
