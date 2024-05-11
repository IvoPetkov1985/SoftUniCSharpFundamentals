using System;
using System.Linq;

namespace _01._Santa_s_Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int batchesCount = int.Parse(Console.ReadLine());

            int singleCookieGrams = 25;
            int cookiesPerBox = 5;
            int cup = 140;
            int smallSpoon = 10;
            int bigSpoon = 20;

            int totalBoxes = 0;

            for (int i = 0; i < batchesCount; i++)
            {
                int flour = int.Parse(Console.ReadLine());
                int sugar = int.Parse(Console.ReadLine());
                int cocoa = int.Parse(Console.ReadLine());

                int flourCups = flour / cup;
                int sugarSpoons = sugar / bigSpoon;
                int cocoaSpoons = cocoa / smallSpoon;

                if (flourCups <= 0 || sugarSpoons <= 0 || cocoaSpoons <= 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                }
                else
                {
                    int[] ingredients = { flourCups, sugarSpoons, cocoaSpoons };
                    int totalCookies = (cup + smallSpoon + bigSpoon) * ingredients.Min() / singleCookieGrams;
                    int boxesPerBatch = totalCookies / cookiesPerBox;
                    Console.WriteLine($"Boxes of cookies: {boxesPerBatch}");
                    totalBoxes += boxesPerBatch;
                }
            }

            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}
