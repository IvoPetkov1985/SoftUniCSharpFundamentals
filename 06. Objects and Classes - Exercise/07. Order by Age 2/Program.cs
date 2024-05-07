using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string infoLine = Console.ReadLine();
            List<Person> personList = new List<Person>();

            while (infoLine != "End")
            {
                string[] personInfo = infoLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                string id = personInfo[1];
                int age = int.Parse(personInfo[2]);

                Person person = personList.FirstOrDefault(x => x.ID == id);

                if (person != null)
                {
                    person.Name = name;
                    person.ID = id;
                    person.Age = age;
                }
                else
                {
                    person = new Person();
                    person.Name = name;
                    person.ID = id;
                    person.Age = age;
                    personList.Add(person);
                }

                infoLine = Console.ReadLine();
            }

            foreach (Person current in personList.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{current.Name} with ID: {current.ID} is {current.Age} years old.");
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
