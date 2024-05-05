using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            byte firstEmployeeEfficiency = byte.Parse(Console.ReadLine());
            byte secondEmployeeEfficiency = byte.Parse(Console.ReadLine());
            byte thirdEmployeeEfficiency = byte.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int efficiencyPerHour = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;
            int hours = 0;

            while (studentsCount > 0)
            {
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
