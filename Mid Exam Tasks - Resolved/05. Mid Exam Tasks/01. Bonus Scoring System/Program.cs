using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            byte studentsCount = byte.Parse(Console.ReadLine());
            byte lecturesCount = byte.Parse(Console.ReadLine());
            byte additionalBonus = byte.Parse(Console.ReadLine());

            double maxBonus = 0.0;
            byte studentAttendances = 0;

            for (int i = 1; i <= studentsCount; i++)
            {
                byte attendances = byte.Parse(Console.ReadLine());

                double totalBonus = attendances / (double)lecturesCount * (5 + additionalBonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    studentAttendances = attendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {studentAttendances} lectures.");
        }
    }
}
