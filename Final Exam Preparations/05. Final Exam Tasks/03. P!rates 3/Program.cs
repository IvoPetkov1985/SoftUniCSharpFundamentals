using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, int[]> cities = new Dictionary<string, int[]>();

            while (inputLine != "Sail")
            {
                string[] details = inputLine.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string city = details.First();
                int population = int.Parse(details[1]);
                int gold = int.Parse(details.Last());

                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, new int[2]);
                    cities[city][0] = 0;
                    cities[city][1] = 0;
                }

                cities[city][0] += population;
                cities[city][1] += gold;

                inputLine = Console.ReadLine();
            }

            string eventLine = Console.ReadLine();

            while (eventLine != "End")
            {
                string[] cmdArgs = eventLine.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string commandName = cmdArgs.First();
                string cityName = cmdArgs[1];

                if (commandName == "Plunder")
                {
                    int people = int.Parse(cmdArgs[2]);
                    int gold = int.Parse(cmdArgs.Last());

                    cities[cityName][0] -= people;
                    cities[cityName][1] -= gold;

                    Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (cities[cityName][0] == 0 || cities[cityName][1] == 0)
                    {
                        cities.Remove(cityName);

                        Console.WriteLine($"{cityName} has been wiped off the map!");
                    }
                }
                else if (commandName == "Prosper")
                {
                    int gold = int.Parse(cmdArgs.Last());

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[cityName][1] += gold;

                        Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {cities[cityName][1]} gold.");
                    }
                }

                eventLine = Console.ReadLine();
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (KeyValuePair<string, int[]> kvp in cities)
                {
                    string cityName = kvp.Key;
                    int population = kvp.Value[0];
                    int gold = kvp.Value[1];

                    Console.WriteLine($"{cityName} -> Population: {population} citizens, Gold: {gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
