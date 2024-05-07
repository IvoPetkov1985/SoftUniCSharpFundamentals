using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            List<Student> studentsList = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split(" ");
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);

                Student student = new Student(firstName, lastName, grade);
                studentsList.Add(student);
            }

            foreach (Student currentStudent in studentsList.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine(currentStudent);
            }
        }
    }

    public class Student
    {
        public Student(string fName, string lName, double grade)
        {
            FirstName = fName;
            LastName = lName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
