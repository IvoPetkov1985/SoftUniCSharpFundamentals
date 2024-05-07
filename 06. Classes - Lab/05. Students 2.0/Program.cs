using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentInfo = Console.ReadLine();
            List<Student> studentsList = new List<Student>();

            while (studentInfo != "end")
            {
                string[] tokens = studentInfo.Split(" ");
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                Student student = studentsList.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

                if (student == null)
                {
                    student = new Student(firstName, lastName, age, homeTown);
                    studentsList.Add(student);
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }

                studentInfo = Console.ReadLine();
            }

            string town = Console.ReadLine();
            List<Student> filtered = studentsList.Where(s => s.HomeTown == town).ToList();
            filtered.ForEach(s => Console.WriteLine(s));
        }
    }

    public class Student
    {
        public Student(string fName, string lName, int age, string town)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            HomeTown = town;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
