using System;

namespace _01._Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfPlunder = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double plunderGathered = 0.0;

            for (int i = 1; i <= daysOfPlunder; i++)
            {
                if (i % 3 == 0)
                {
                    plunderGathered += dailyPlunder * 1.5;
                }
                else
                {
                    plunderGathered += dailyPlunder;
                }

                if (i % 5 == 0)
                {
                    plunderGathered *= 0.7;
                }
            }

            if (plunderGathered >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {plunderGathered:F2} plunder gained.");
            }
            else
            {
                double percentage = plunderGathered / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }
        }
    }
}
