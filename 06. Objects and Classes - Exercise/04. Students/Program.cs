using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> studentsList = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                string studentInfoLine = Console.ReadLine();
                string[] tokens = studentInfoLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = tokens[0];
                string lastName = tokens[1];
                double grade = double.Parse(tokens[2]);

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Grade = grade;

                studentsList.Add(student);
            }

            foreach (Student currentStudent in studentsList.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName}: {currentStudent.Grade:F2}");
            }
        }
    }
}

public class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public double Grade { get; set; }
}
