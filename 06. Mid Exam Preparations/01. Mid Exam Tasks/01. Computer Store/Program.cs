using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            decimal sumWithoutTaxes = 0;

            while (true)
            {
                if (command == "special" || command == "regular")
                {
                    break;
                }

                decimal currentPrice = decimal.Parse(command);

                if (currentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    sumWithoutTaxes += currentPrice;
                }

                command = Console.ReadLine();
            }

            decimal taxes = sumWithoutTaxes * 0.20m;
            decimal totalSum = sumWithoutTaxes + taxes;
            decimal discountPrice = totalSum * 0.90m;

            if (sumWithoutTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sumWithoutTaxes:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");

                if (command == "regular")
                {
                    Console.WriteLine($"Total price: {totalSum:F2}$");
                }
                else
                {
                    Console.WriteLine($"Total price: {discountPrice:F2}$");
                }
            }
        }
    }
}
