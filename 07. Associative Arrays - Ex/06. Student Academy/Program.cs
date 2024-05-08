using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < rowsCount; i++)
            {
                string studentName = Console.ReadLine();
                double currentGrade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades.Add(studentName, new List<double>());
                }

                studentGrades[studentName].Add(currentGrade);
            }

            foreach (var (student, grade) in studentGrades)
            {
                if (grade.Average() >= 4.50)
                {
                    Console.WriteLine($"{student} -> {grade.Average():F2}");
                }
            }
        }
    }
}
