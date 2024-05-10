using System;
using System.Linq;

namespace _01._World_Tour_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string travelStops = Console.ReadLine();

            while (true)
            {
                string commandLine = Console.ReadLine();

                if (commandLine == "Travel")
                {
                    Console.WriteLine($"Ready for world tour! Planned stops: {travelStops}");
                    break;
                }

                string[] tokens = commandLine.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens.First();

                switch (command)
                {
                    case "Add Stop":
                        int index = int.Parse(tokens[1]);
                        string stop = tokens.Last();

                        if (index >= 0 && index < travelStops.Length)
                        {
                            travelStops = travelStops.Insert(index, stop);
                        }
                        break;

                    case "Remove Stop":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens.Last());

                        if (startIndex >= 0 && startIndex < travelStops.Length
                            && endIndex >= 0 && endIndex < travelStops.Length)
                        {
                            travelStops = travelStops.Remove(startIndex, endIndex - startIndex + 1);
                        }
                        break;

                    case "Switch":
                        string oldStop = tokens[1];
                        string newStop = tokens.Last();

                        if (travelStops.Contains(oldStop))
                        {
                            travelStops = travelStops.Replace(oldStop, newStop);
                        }
                        break;
                }

                Console.WriteLine(travelStops);
            }
        }
    }
}
