using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int plantsCount = int.Parse(Console.ReadLine());
            List<Plant> plantation = new List<Plant>();

            for (int i = 0; i < plantsCount; i++)
            {
                string inputLine = Console.ReadLine();
                string[] plantDetails = inputLine.Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plantName = plantDetails.First();
                int rarity = int.Parse(plantDetails.Last());

                Plant plant = new Plant();
                plant.PlantName = plantName;
                plant.Rarity = rarity;
                plantation.Add(plant);
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Exhibition")
            {
                string[] tokens = commandLine.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens.First();

                if (command == "Rate")
                {
                    string[] details = tokens.Last().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string plantName = details.First();
                    int rating = int.Parse(details.Last());

                    Plant plantToRate = plantation.FirstOrDefault(x => x.PlantName == plantName);

                    if (plantToRate != null)
                    {
                        plantToRate.Rating.Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "Update")
                {
                    string[] plantDetails = tokens.Last().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string plantName = plantDetails.First();
                    int newRarity = int.Parse(plantDetails.Last());

                    Plant plantToUpdate = plantation.FirstOrDefault(x => x.PlantName == plantName);

                    if (plantToUpdate != null)
                    {
                        plantToUpdate.Rarity = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "Reset")
                {
                    string plant = tokens.Last();

                    Plant plantToReset = plantation.FirstOrDefault(x => x.PlantName == plant);

                    if (plantToReset != null)
                    {
                        plantToReset.Rating.Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (Plant plant in plantation)
            {
                if (plant.Rating.Count == 0)
                {
                    Console.WriteLine($"- {plant.PlantName}; Rarity: {plant.Rarity}; Rating: 0.00");
                }
                else
                {
                    double average = plant.Rating.Average();
                    Console.WriteLine($"- {plant.PlantName}; Rarity: {plant.Rarity}; Rating: {average:F2}");
                }
            }
        }
    }

    public class Plant
    {
        public Plant()
        {
            Rating = new List<int>();
        }
        public string PlantName { get; set; }
        public int Rarity { get; set; }
        public List<int> Rating { get; set; }
    }
}
