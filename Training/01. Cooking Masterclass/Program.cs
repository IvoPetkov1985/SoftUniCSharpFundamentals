using System;

namespace _01._Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            decimal packageFlourPrice = decimal.Parse(Console.ReadLine());
            decimal singleEggPrice = decimal.Parse(Console.ReadLine());
            decimal singleApronPrice = decimal.Parse(Console.ReadLine());

            int totalFlourPackages = studentsCount;
            int freeFlourPackages = totalFlourPackages / 5;
            totalFlourPackages -= freeFlourPackages;
            decimal priceForFlour = totalFlourPackages * packageFlourPrice;

            decimal totalEggsPrice = singleEggPrice * 10 * studentsCount;

            int totalAprons = (int)Math.Ceiling(studentsCount * 1.2);
            decimal totalApronsPrice = totalAprons * singleApronPrice;

            decimal sumNeeded = totalApronsPrice + totalEggsPrice + priceForFlour;

            if (budget >= sumNeeded)
            {
                Console.WriteLine($"Items perchased for {sumNeeded:F2}$.");
            }
            else
            {
                Console.WriteLine($"{sumNeeded - budget:F2}$ more needed.");
            }
        }
    }
}
