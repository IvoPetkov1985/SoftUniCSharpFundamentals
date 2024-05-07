using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            decimal totalSum = 0;

            while (command != "regular" && command != "special")
            {
                decimal currentPrice = decimal.Parse(command);

                if (currentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalSum += currentPrice;
                }

                command = Console.ReadLine();
            }

            decimal taxRate = 0.20m;

            if (totalSum == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalSum:F2}$");
                Console.WriteLine($"Taxes: {totalSum * taxRate:F2}$");
                Console.WriteLine("-----------");

                if (command == "regular")
                {
                    Console.WriteLine($"Total price: {totalSum + totalSum * taxRate:F2}$");
                }
                else
                {
                    Console.WriteLine($"Total price: {(totalSum + totalSum * taxRate) * 0.90m:F2}$");
                }
            }
        }
    }
}
