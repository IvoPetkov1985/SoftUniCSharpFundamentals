using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentInfo = Console.ReadLine();
            List<Student> studentsList = new List<Student>();

            while (studentInfo != "end")
            {
                string[] studentTokens = studentInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string fName = studentTokens[0];
                string lName = studentTokens[1];
                int age = int.Parse(studentTokens[2]);
                string city = studentTokens[3];
                Student student = new Student(fName, lName, age, city);
                studentsList.Add(student);

                studentInfo = Console.ReadLine();
            }

            string cityName = Console.ReadLine();

            foreach (Student student in studentsList.FindAll(x => x.HomeTown == cityName))
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
