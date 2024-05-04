using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            OrderCalculator(product, quantity);
        }

        static void OrderCalculator(string product, int count)
        {
            decimal orderPrice = 0.0m;

            switch (product)
            {
                case "coffee": orderPrice = 1.50m * count; break;
                case "water": orderPrice = 1.00m * count; break;
                case "coke": orderPrice = 1.40m * count; break;
                case "snacks": orderPrice = 2.00m * count; break;
            }

            Console.WriteLine("{0:F2}", orderPrice);
        }
    }
}
