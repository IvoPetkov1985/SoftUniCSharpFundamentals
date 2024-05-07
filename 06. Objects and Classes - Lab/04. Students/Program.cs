using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentInfoLine = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (studentInfoLine != "end")
            {
                string[] studentDetails = studentInfoLine.Split(" ");
                string firstName = studentDetails[0];
                string lastName = studentDetails[1];
                int studentAge = int.Parse(studentDetails[2]);
                string homeTown = studentDetails[3];

                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = studentAge;
                student.HomeTown = homeTown;

                students.Add(student);

                studentInfoLine = Console.ReadLine();
            }

            string desiredTown = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == desiredTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
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
