using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            List<Vehicle> vehicles = new List<Vehicle>();

            while (inputLine != "End")
            {
                string[] inputTokens = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = inputTokens[0];
                string model = inputTokens[1];
                string color = inputTokens[2];
                int horsePower = int.Parse(inputTokens[3]);

                Vehicle vehicle = new Vehicle();
                vehicle.Type = type;
                vehicle.Model = model;
                vehicle.Color = color;
                vehicle.HorsePower = horsePower;
                vehicles.Add(vehicle);

                inputLine = Console.ReadLine();
            }

            string currentModel = Console.ReadLine();

            while (currentModel != "Close the Catalogue")
            {
                var currentVehicle = vehicles.Find(x => x.Model == currentModel);

                if (currentVehicle.Type == "car")
                {
                    Console.WriteLine($"Type: Car");
                    Console.WriteLine($"Model: {currentVehicle.Model}");
                    Console.WriteLine($"Color: {currentVehicle.Color}");
                    Console.WriteLine($"Horsepower: {currentVehicle.HorsePower}");
                }
                else
                {
                    Console.WriteLine($"Type: Truck");
                    Console.WriteLine($"Model: {currentVehicle.Model}");
                    Console.WriteLine($"Color: {currentVehicle.Color}");
                    Console.WriteLine($"Horsepower: {currentVehicle.HorsePower}");
                }

                currentModel = Console.ReadLine();
            }

            List<Vehicle> carsOnly = vehicles.Where(x => x.Type == "car").ToList();
            List<Vehicle> trucksOnly = vehicles.Where(x => x.Type == "truck").ToList();
            double averageCarsPower = carsOnly.Select(x => x.HorsePower).Sum() / (double)carsOnly.Count;
            double averageTrucksPower = trucksOnly.Select(x => x.HorsePower).Sum() / (double)trucksOnly.Count;

            if (carsOnly.Any())
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsPower:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }
            if (trucksOnly.Any())
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksPower:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }
        }
    }

    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
}
