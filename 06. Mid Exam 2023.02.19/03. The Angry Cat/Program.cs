using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Angry_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceRatings = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();

            int leftSum = 0;

            for (int i = 0; i < entryPoint; i++)
            {
                int currentItemPrice = priceRatings[i];

                if (typeOfItems == "cheap")
                {
                    if (currentItemPrice < priceRatings[entryPoint])
                    {
                        leftSum += currentItemPrice;
                    }
                }
                else if (typeOfItems == "expensive")
                {
                    if (currentItemPrice >= priceRatings[entryPoint])
                    {
                        leftSum += currentItemPrice;
                    }
                }
            }

            int rightSum = 0;

            for (int i = priceRatings.Length - 1; i > entryPoint; i--)
            {
                int currentItemPrice = priceRatings[i];

                if (typeOfItems == "cheap")
                {
                    if (currentItemPrice < priceRatings[entryPoint])
                    {
                        rightSum += currentItemPrice;
                    }
                }
                else if (typeOfItems == "expensive")
                {
                    if (currentItemPrice >= priceRatings[entryPoint])
                    {
                        rightSum += currentItemPrice;
                    }
                }
            }

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }
    }
}
