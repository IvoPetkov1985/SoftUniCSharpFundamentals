using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairsCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsInfo = new Dictionary<string, List<double>>();

            for (int i = 1; i <= pairsCount; i++)
            {
                string name = Console.ReadLine();
                double currentGrade = double.Parse(Console.ReadLine());

                if (!studentsInfo.ContainsKey(name))
                {
                    studentsInfo[name] = new List<double>();
                }

                studentsInfo[name].Add(currentGrade);
            }

            foreach (KeyValuePair<string, List<double>> kvp in studentsInfo)
            {
                List<double> grades = kvp.Value;
                double averageGrade = grades.Average();
                string studentName = kvp.Key;

                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{studentName} -> {averageGrade:f2}");
                }
            }
        }
    }
}
