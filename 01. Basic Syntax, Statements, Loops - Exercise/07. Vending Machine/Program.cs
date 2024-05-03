using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sumMoney = 0.00m;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Start")
                {
                    break;
                }

                decimal coinValue = decimal.Parse(command);

                if (coinValue == 0.1m || coinValue == 0.2m || coinValue == 0.5m || coinValue == 1 || coinValue == 2)
                {
                    sumMoney += coinValue;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coinValue}");
                }
            }

            decimal price = 0.00m;
            bool isValid = true;

            while (true)
            {
                string nextCommand = Console.ReadLine();

                if (nextCommand == "End")
                {
                    break;
                }

                string currentProduct = nextCommand;

                if (currentProduct == "Nuts")
                {
                    price = 2.00m;
                }
                else if (currentProduct == "Water")
                {
                    price = 0.70m;
                }
                else if (currentProduct == "Crisps")
                {
                    price = 1.50m;
                }
                else if (currentProduct == "Soda")
                {
                    price = 0.80m;
                }
                else if (currentProduct == "Coke")
                {
                    price = 1.00m;
                }
                else
                {
                    isValid = false;
                    Console.WriteLine("Invalid product");
                }

                if (price > sumMoney)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    if (isValid)
                    {
                        sumMoney -= price;
                        Console.WriteLine($"Purchased {currentProduct.ToLower()}");
                    }
                }
            }

            Console.WriteLine($"Change: {sumMoney:F2}");
        }
    }
}
