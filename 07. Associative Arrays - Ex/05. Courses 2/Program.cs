using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, List<string>> coursesInfo = new Dictionary<string, List<string>>();

            while (inputLine != "end")
            {
                string[] data = inputLine.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = data[0];
                string studentName = data[1];

                if (!coursesInfo.ContainsKey(courseName))
                {
                    coursesInfo[courseName] = new List<string>();
                }

                coursesInfo[courseName].Add(studentName);

                inputLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> kvp in coursesInfo)
            {
                int studentsCount = kvp.Value.Count;
                string course = kvp.Key;
                Console.WriteLine($"{course}: {studentsCount}");

                foreach (string student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
