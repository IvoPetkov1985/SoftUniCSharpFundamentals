using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> carsList = new List<Car>();

            for (int i = 1; i <= carsCount; i++)
            {
                string carInfo = Console.ReadLine();
                string[] carTokens = carInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carTokens[0];
                double fuelAmount = double.Parse(carTokens[1]);
                double consumption = double.Parse(carTokens[2]);

                Car car = new Car();
                car.Model = model;
                car.FuelAmount = fuelAmount;
                car.FuelConsumption = consumption;
                carsList.Add(car);
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = tokens[1];
                double amountKm = double.Parse(tokens[2]);
                carsList.Find(x => x.Model == carModel).Drive(amountKm);

                commandLine = Console.ReadLine();
            }

            foreach (Car car in carsList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TraveledDistance}");
            }
        }
    }

    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double TraveledDistance { get; set; }

        public void Drive(double km)
        {
            if (FuelConsumption * km <= FuelAmount)
            {
                FuelAmount -= FuelConsumption * km;
                TraveledDistance += km;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
