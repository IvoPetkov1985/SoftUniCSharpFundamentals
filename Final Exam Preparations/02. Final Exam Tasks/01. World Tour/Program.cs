using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string commandLine = Console.ReadLine();

            while (commandLine != "Travel")
            {
                string[] tokens = commandLine.Split(":");
                string command = tokens[0];

                switch (command)
                {
                    case "Add Stop":
                        int index = int.Parse(tokens[1]);
                        string stopToAdd = tokens[2];

                        if (index >= 0 && index < stops.Length)
                        {
                            stops = stops.Insert(index, stopToAdd);
                            Console.WriteLine(stops);
                        }
                        else
                        {
                            Console.WriteLine(stops);
                        }
                        break;

                    case "Remove Stop":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);

                        if (startIndex >= 0 && startIndex < stops.Length
                            && endIndex >= 0 && endIndex < stops.Length)
                        {
                            stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                            Console.WriteLine(stops);
                        }
                        else
                        {
                            Console.WriteLine(stops);
                        }
                        break;

                    case "Switch":
                        string oldSequence = tokens[1];
                        string newSequence = tokens[2];

                        if (stops.Contains(oldSequence))
                        {
                            stops = stops.Replace(oldSequence, newSequence);
                            Console.WriteLine(stops);
                        }
                        else
                        {
                            Console.WriteLine(stops);
                        }
                        break;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
