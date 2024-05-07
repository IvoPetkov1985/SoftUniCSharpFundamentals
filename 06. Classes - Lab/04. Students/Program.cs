using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
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
                string city = tokens[3];

                Student student = new Student(firstName, lastName, age, city);
                studentsList.Add(student);

                studentInfo = Console.ReadLine();
            }

            string inputCity = Console.ReadLine();
            List<Student> filteredList = studentsList.FindAll(s => s.HomeTown == inputCity);
            filteredList.ForEach(s => Console.WriteLine(s));
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
