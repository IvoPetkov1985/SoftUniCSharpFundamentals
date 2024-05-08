using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, List<string>> students = new Dictionary<string, List<string>>();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = tokens[0];
                string studentName = tokens[1];

                if (!students.ContainsKey(courseName))
                {
                    students.Add(courseName, new List<string>());
                }

                students[courseName].Add(studentName);

                inputLine = Console.ReadLine();
            }

            foreach (var (key, value) in students)
            {
                Console.WriteLine($"{key}: {value.Count}");

                foreach (string name in value)
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
