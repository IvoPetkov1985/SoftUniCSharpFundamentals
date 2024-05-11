using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                string inputLine = Console.ReadLine();
                int firstNameIndex = inputLine.IndexOf("@");
                int secondNameIndex = inputLine.IndexOf("|");
                string name = inputLine.Substring(firstNameIndex + 1, secondNameIndex - firstNameIndex - 1);
                int firstAgeIndex = inputLine.IndexOf("#");
                int secondAgeIndex = inputLine.IndexOf("*");
                string personAge = inputLine.Substring(firstAgeIndex + 1, secondAgeIndex - firstAgeIndex - 1);
                int age = int.Parse(personAge);

                Person person = new Person(name, age);
                people.Add(person);
            }

            foreach (Person person1 in people)
            {
                Console.WriteLine(person1);
            }
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} is {Age} years old.";
        }
    }
}
