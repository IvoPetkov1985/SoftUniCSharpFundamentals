using System;

namespace _01._Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal foodInKg = decimal.Parse(Console.ReadLine());
            decimal hayInKg = decimal.Parse(Console.ReadLine());
            decimal coverInKg = decimal.Parse(Console.ReadLine());
            decimal pigInKg = decimal.Parse(Console.ReadLine());

            bool isEverythingFine = true;

            for (int i = 1; i <= 30; i++)
            {
                foodInKg -= 0.3m;

                if (i % 2 == 0)
                {
                    decimal hay = foodInKg * 0.05m;
                    hayInKg -= hay;
                }

                if (i % 3 == 0)
                {
                    decimal cover = pigInKg / 3;
                    coverInKg -= cover;
                }

                if (foodInKg <= 0 || hayInKg <= 0 || coverInKg <= 0)
                {
                    isEverythingFine = false;
                    break;
                }
            }

            if (isEverythingFine)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodInKg:F2}, Hay: {hayInKg:F2}, Cover: {coverInKg:F2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}
