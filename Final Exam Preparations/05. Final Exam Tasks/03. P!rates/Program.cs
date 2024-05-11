using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string infoLine = Console.ReadLine();
            Dictionary<string, int[]> cities = new Dictionary<string, int[]>();

            while (infoLine != "Sail")
            {
                string[] cityDetails = infoLine.Split("||");
                string cityName = cityDetails[0];
                int population = int.Parse(cityDetails[1]);
                int gold = int.Parse(cityDetails[2]);

                if (!cities.ContainsKey(cityName))
                {
                    cities.Add(cityName, new int[2]);
                    cities[cityName][0] = population;
                    cities[cityName][1] = gold;
                }
                else
                {
                    cities[cityName][0] += population;
                    cities[cityName][1] += gold;
                }

                infoLine = Console.ReadLine();
            }

            string eventLine = Console.ReadLine();

            while (eventLine != "End")
            {
                string[] tokens = eventLine.Split("=>");
                string command = tokens[0];
                string city = tokens[1];

                if (command == "Plunder")
                {
                    int people = int.Parse(tokens[2]);
                    int gold = int.Parse(tokens[3]);

                    cities[city][0] -= people;
                    cities[city][1] -= gold;

                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (cities[city][0] == 0 || cities[city][1] == 0)
                    {
                        cities.Remove(city);
                        Console.WriteLine($"{city} has been wiped off the map!");
                    }
                }
                else if (command == "Prosper")
                {
                    int goldToAdd = int.Parse(tokens[2]);

                    if (goldToAdd < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[city][1] += goldToAdd;
                        Console.WriteLine($"{goldToAdd} gold added to the city treasury. {city} now has {cities[city][1]} gold.");
                    }
                }

                eventLine = Console.ReadLine();
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (KeyValuePair<string, int[]> kvp in cities)
                {
                    Console.WriteLine($"{kvp.Key} -> Population: {kvp.Value[0]} citizens, Gold: {kvp.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
