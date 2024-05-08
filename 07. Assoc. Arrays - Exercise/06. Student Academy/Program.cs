using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsInfo = new Dictionary<string, List<double>>();

            for (int i = 1; i <= gradesCount; i++)
            {
                string studentName = Console.ReadLine();
                double currentGrade = double.Parse(Console.ReadLine());

                if (!studentsInfo.ContainsKey(studentName))
                {
                    studentsInfo[studentName] = new List<double>();
                }

                studentsInfo[studentName].Add(currentGrade);
            }

            foreach (KeyValuePair<string, List<double>> kvp in studentsInfo)
            {
                string name = kvp.Key;
                List<double> gradesList = kvp.Value;
                double averageGrade = gradesList.Average();

                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{name} -> {averageGrade:F2}");
                }
            }
        }
    }
}
