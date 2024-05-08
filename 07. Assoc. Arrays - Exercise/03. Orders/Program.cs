using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandLine = Console.ReadLine();
            Dictionary<string, double[]> productsToBuy = new Dictionary<string, double[]>();

            while (commandLine != "buy")
            {
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string productName = tokens[0];
                double price = double.Parse(tokens[1]);
                double quantity = double.Parse(tokens[2]);

                if (!productsToBuy.ContainsKey(productName))
                {
                    productsToBuy[productName] = new double[2];
                }

                productsToBuy[productName][0] = price;
                productsToBuy[productName][1] += quantity;

                commandLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, double[]> kvp in productsToBuy)
            {
                string product = kvp.Key;
                double[] productInfo = kvp.Value;
                double totalPrice = productInfo[0] * productInfo[1];

                Console.WriteLine($"{product} -> {totalPrice:f2}");
            }
        }
    }
}
