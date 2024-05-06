using System;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDayForPerson = double.Parse(Console.ReadLine());
            double foodPerDayForPerson = double.Parse(Console.ReadLine());

            double groupWater = daysCount * playersCount * waterPerDayForPerson;
            double groupFood = daysCount * playersCount * foodPerDayForPerson;

            for (int i = 1; i <= daysCount; i++)
            {
                double energyLost = double.Parse(Console.ReadLine());

                groupEnergy -= energyLost;

                if (groupEnergy <= 0)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    groupEnergy *= 1.05;
                    groupWater *= 0.7;
                }
                if (i % 3 == 0)
                {
                    groupEnergy *= 1.10;
                    groupFood -= groupFood / playersCount;
                }
            }

            if (groupEnergy <= 0)
            {
                Console.WriteLine($"You will run out of energy. You will be left with {groupFood:F2} food and {groupWater:F2} water.");
            }
            else
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:F2} energy!");
            }
        }
    }
}
