using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            byte studentsCount = byte.Parse(Console.ReadLine());
            byte totalLectures = byte.Parse(Console.ReadLine());
            byte addedBonus = byte.Parse(Console.ReadLine());
            double maxBonus = 0.0;
            byte lecturesAttended = 0;

            for (byte i = 1; i <= studentsCount; i++)
            {
                byte studentAttendances = byte.Parse(Console.ReadLine());
                double totalBonus = studentAttendances / (double)totalLectures * (5 + addedBonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    lecturesAttended = studentAttendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {lecturesAttended} lectures.");
        }
    }
}
