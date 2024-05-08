using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            Dictionary<string, List<string>> coursesInfo = new Dictionary<string, List<string>>();

            while (inputData != "end")
            {
                string[] tokens = inputData.Split(" : ");
                string courseName = tokens[0];
                string studentName = tokens[1];

                if (!coursesInfo.ContainsKey(courseName))
                {
                    coursesInfo[courseName] = new List<string>();
                }

                coursesInfo[courseName].Add(studentName);

                inputData = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> kvp in coursesInfo)
            {
                string course = kvp.Key;
                List<string> students = kvp.Value;

                Console.WriteLine($"{course}: {students.Count}");

                foreach (string student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
