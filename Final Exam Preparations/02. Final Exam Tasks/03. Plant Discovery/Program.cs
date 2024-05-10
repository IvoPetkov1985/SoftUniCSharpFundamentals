using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            List<Plant> plants = new List<Plant>();

            for (int i = 0; i < linesCount; i++)
            {
                string inputLine = Console.ReadLine();
                string[] inputTokens = inputLine.Split("<->");
                string plantName = inputTokens[0];
                int rarity = int.Parse(inputTokens[1]);

                Plant plant = plants.FirstOrDefault(x => x.Name == plantName);
                if (plant == null)
                {
                    plant = new Plant();
                    plant.Name = plantName;
                    plant.Rarity = rarity;
                    plants.Add(plant);
                }
                else
                {
                    plant.Rarity = rarity;
                }
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Exhibition")
            {
                string[] tokens = commandLine.Split(": ");
                string command = tokens[0];

                switch (command)
                {
                    case "Rate":
                        string[] ratingTokens = tokens[1].Split(" - ");
                        string plantName = ratingTokens[0];
                        int rating = int.Parse(ratingTokens[1]);

                        Plant plantToRate = plants.FirstOrDefault(x => x.Name == plantName);
                        if (plantToRate == null)
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            plantToRate.Ratings.Add(rating);
                        }
                        break;

                    case "Update":
                        string[] updateTokens = tokens[1].Split(" - ");
                        string plant = updateTokens[0];
                        int newRarity = int.Parse(updateTokens[1]);

                        Plant plantToUpdate = plants.FirstOrDefault(x => x.Name == plant);
                        if (plantToUpdate == null)
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            plantToUpdate.Rarity = newRarity;
                        }
                        break;

                    case "Reset":
                        string plantToReset = tokens[1];

                        Plant plant1 = plants.FirstOrDefault(x => x.Name == plantToReset);
                        if (plant1 == null)
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            plant1.Ratings.Clear();
                        }
                        break;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (Plant plant in plants)
            {
                if (plant.Ratings.Count == 0)
                {
                    Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: 0.00");
                }
                else
                {
                    double averageRating = plant.Ratings.Average();
                    Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {averageRating:F2}");
                }
            }
        }
    }

    public class Plant
    {
        public Plant()
        {
            Ratings = new List<int>();
        }

        public string Name { get; set; }
        public int Rarity { get; set; }
        public List<int> Ratings { get; set; }
    }
}
