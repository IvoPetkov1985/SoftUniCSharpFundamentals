using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEfficience = int.Parse(Console.ReadLine());
            int secondEfficience = int.Parse(Console.ReadLine());
            int thirdEfficience = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int efficiencyPerHour = firstEfficience + secondEfficience + thirdEfficience;
            int hours = 0;

            while (true)
            {
                if (studentsCount <= 0)
                {
                    break;
                }

                hours++;

                if (hours % 4 == 0)
                {
                    continue;
                }

                studentsCount -= efficiencyPerHour;
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
