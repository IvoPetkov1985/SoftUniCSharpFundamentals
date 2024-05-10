using System;
using System.Text;
using System.Linq;

namespace _01._World_Tour_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string destinations = Console.ReadLine();

            string commandLine = Console.ReadLine();

            while (commandLine != "Travel")
            {
                string[] tokens = commandLine
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens.First();

                if (command == "Add Stop")
                {
                    int index = int.Parse(tokens[1]);
                    string value = tokens.Last();

                    if (index >= 0 && index < destinations.Length)
                    {
                        destinations = destinations.Insert(index, value);
                    }
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens.Last());

                    if (startIndex >= 0 && startIndex < destinations.Length
                        && endIndex >= 0 && endIndex < destinations.Length)
                    {
                        destinations = destinations.Remove(startIndex, endIndex - startIndex + 1);
                    }
                }
                else if (command == "Switch")
                {
                    string oldValue = tokens[1];
                    string newValue = tokens.Last();

                    if (destinations.Contains(oldValue))
                    {
                        destinations = destinations.Replace(oldValue, newValue);
                    }
                }

                Console.WriteLine(destinations);
                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
        }
    }
}
