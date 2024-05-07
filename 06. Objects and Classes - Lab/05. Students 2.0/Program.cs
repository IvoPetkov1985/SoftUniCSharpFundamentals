using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentInfo = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (studentInfo != "end")
            {
                string[] studentDetails = studentInfo.Split(" ");

                string firstName = studentDetails[0];
                string lastName = studentDetails[1];
                int age = int.Parse(studentDetails[2]);
                string town = studentDetails[3];

                Student student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

                if (student != null)
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = town;
                }
                else
                {
                    student = new Student();

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = town;

                    students.Add(student);
                }

                studentInfo = Console.ReadLine();
            }

            string cityName = Console.ReadLine();

            List<Student> filtered = students.Where(x => x.HomeTown == cityName).ToList();

            foreach (Student student in filtered)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
}
