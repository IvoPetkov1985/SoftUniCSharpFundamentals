using System;

namespace _01._Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodInKg = double.Parse(Console.ReadLine());
            double hayInKg = double.Parse(Console.ReadLine());
            double coverInKg = double.Parse(Console.ReadLine());
            double pigWeightInKg = double.Parse(Console.ReadLine());

            double foodInGrams = foodInKg * 1000;
            double hayInGrams = hayInKg * 1000;
            double coverInGrams = coverInKg * 1000;
            double pigWeightInGrams = pigWeightInKg * 1000;

            bool isEverythingFine = true;

            for (int i = 1; i <= 30; i++)
            {
                if (foodInGrams > 300)
                {
                    foodInGrams -= 300;
                }
                else
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    isEverythingFine = false;
                    break;
                }

                if (i % 2 == 0)
                {
                    double dayHay = foodInGrams * 0.05;

                    if (hayInGrams > dayHay)
                    {
                        hayInGrams -= dayHay;
                    }
                    else
                    {
                        Console.WriteLine("Merry must go to the pet store!");
                        isEverythingFine = false;
                        break;
                    }
                }

                if (i % 3 == 0)
                {
                    double dayCover = pigWeightInGrams / 3;

                    if (coverInGrams > dayCover)
                    {
                        coverInGrams -= dayCover;
                    }
                    else
                    {
                        Console.WriteLine("Merry must go to the pet store!");
                        isEverythingFine = false;
                        break;
                    }
                }
            }

            if (isEverythingFine)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(foodInGrams / 1000):F2}, Hay: {(hayInGrams / 1000):F2}, Cover: {(coverInGrams / 1000):F2}.");
            }
        }
    }
}
