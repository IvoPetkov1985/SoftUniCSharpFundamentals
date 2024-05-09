using System;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string inputLine = Console.ReadLine();
                int firstNameIndex = inputLine.IndexOf('@') + 1;
                int lastNameIndex = inputLine.IndexOf('|');
                int firstAgeIndex = inputLine.IndexOf('#') + 1;
                int lastAgeIndex = inputLine.IndexOf('*');

                string name = inputLine[firstNameIndex..lastNameIndex];
                string age = inputLine[firstAgeIndex..lastAgeIndex];

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
