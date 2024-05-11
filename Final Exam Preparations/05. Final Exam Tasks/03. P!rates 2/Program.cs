using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string infoLine = Console.ReadLine();
            List<City> cities = new List<City>();

            while (infoLine != "Sail")
            {
                string[] cityInfo = infoLine.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string cityName = cityInfo[0];
                int population = int.Parse(cityInfo[1]);
                int gold = int.Parse(cityInfo[2]);

                City city = cities.FirstOrDefault(x => x.Name == cityName);
                if (city != null)
                {
                    city.Population += population;
                    city.Gold += gold;
                }
                else
                {
                    city = new City(cityName, population, gold);
                    cities.Add(city);
                }

                infoLine = Console.ReadLine();
            }

            string eventLine = Console.ReadLine();

            while (eventLine != "End")
            {
                string[] tokens = eventLine.Split("=>");
                string command = tokens[0];
                string cityName = tokens[1];

                switch (command)
                {
                    case "Plunder":
                        int people = int.Parse(tokens[2]);
                        int gold = int.Parse(tokens[3]);

                        City cityToPlunder = cities.Find(x => x.Name == cityName);
                        cityToPlunder.Population -= people;
                        cityToPlunder.Gold -= gold;

                        Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");

                        if (cityToPlunder.Population == 0 || cityToPlunder.Gold == 0)
                        {
                            cities.Remove(cityToPlunder);
                            Console.WriteLine($"{cityName} has been wiped off the map!");
                        }
                        break;

                    case "Prosper":
                        int goldToAdd = int.Parse(tokens[2]);

                        if (goldToAdd < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            City cityToProsper = cities.Find(x => x.Name == cityName);
                            cityToProsper.Gold += goldToAdd;
                            Console.WriteLine($"{goldToAdd} gold added to the city treasury. {cityToProsper.Name} now has {cityToProsper.Gold} gold.");
                        }
                        break;
                }

                eventLine = Console.ReadLine();
            }

            if (cities.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (City city in cities)
                {
                    Console.WriteLine(city);
                }
            }
        }
    }

    public class City
    {
        public City(string name, int population, int gold)
        {
            this.Name = name;
            this.Population = population;
            this.Gold = gold;
        }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
        public override string ToString()
        {
            return $"{Name} -> Population: {Population} citizens, Gold: {Gold} kg";
        }
    }
}
