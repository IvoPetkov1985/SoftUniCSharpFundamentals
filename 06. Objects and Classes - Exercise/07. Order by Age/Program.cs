using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            List<Person> listOfPeople = new List<Person>();

            while (inputLine != "End")
            {
                string[] personInfo = inputLine.Split(" ");
                string name = personInfo[0];
                string id = personInfo[1];
                int age = int.Parse(personInfo[2]);

                Person person = listOfPeople.FirstOrDefault(p => p.ID == id);

                if (person == null)
                {
                    listOfPeople.Add(new Person()                    
                    {
                        Name = name,
                        ID = id,
                        Age = age
                    });                    
                }
                else
                {
                    person.Name = name;
                    person.ID = id;
                    person.Age = age;
                }                

                inputLine = Console.ReadLine();
            }

            foreach (Person current in listOfPeople.OrderBy(x => x.Age))
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

