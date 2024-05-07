using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string infoLine = Console.ReadLine();
            List<Student> studentsList = new List<Student>();

            while (infoLine != "end")
            {
                string[] studentTokens = infoLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = studentTokens[0];
                string lastName = studentTokens[1];
                int age = int.Parse(studentTokens[2]);
                string homeTown = studentTokens[3];

                Student student = studentsList.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

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

                infoLine = Console.ReadLine();
            }

            string desiredCity = Console.ReadLine();

            foreach (Student student in studentsList.FindAll(x => x.HomeTown == desiredCity))
            {
                Console.WriteLine(student);
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
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
