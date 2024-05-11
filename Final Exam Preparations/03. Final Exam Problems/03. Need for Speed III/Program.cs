using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            List<Car> allCars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string inputLine = Console.ReadLine();
                string[] input = inputLine.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string carModel = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);
                Car car = new Car(carModel, mileage, fuel);
                allCars.Add(car);
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Stop")
            {
                string[] cmdArgs = commandLine.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                string model = cmdArgs[1];

                if (command == "Drive")
                {
                    int distance = int.Parse(cmdArgs[2]);
                    int neededFuel = int.Parse(cmdArgs[3]);

                    Car carToDrive = allCars.Find(x => x.Model == model);

                    if (carToDrive.Fuel < neededFuel)
                    {
                        Console.WriteLine($"Not enough fuel to make that ride");
                    }
                    else
                    {
                        carToDrive.Mileage += distance;
                        carToDrive.Fuel -= neededFuel;
                        Console.WriteLine($"{carToDrive.Model} driven for {distance} kilometers. {neededFuel} liters of fuel consumed.");
                    }

                    if (carToDrive.Mileage > 100_000)
                    {
                        allCars.Remove(carToDrive);
                        Console.WriteLine($"Time to sell the {carToDrive.Model}!");
                    }
                }
                else if (command == "Refuel")
                {
                    int fuelToAdd = int.Parse(cmdArgs[2]);

                    Car carToRefuel = allCars.Find(x => x.Model == model);
                    int oldFuelValue = carToRefuel.Fuel;

                    carToRefuel.Fuel += fuelToAdd;

                    if (carToRefuel.Fuel > 75)
                    {
                        carToRefuel.Fuel = 75;
                        Console.WriteLine($"{carToRefuel.Model} refueled with {75 - oldFuelValue} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{carToRefuel.Model} refueled with {fuelToAdd} liters");
                    }
                }
                else if (command == "Revert")
                {
                    int kilometers = int.Parse(cmdArgs[2]);

                    Car carToRevert = allCars.Find(x => x.Model == model);
                    carToRevert.Mileage -= kilometers;

                    if (carToRevert.Mileage < 10_000)
                    {
                        carToRevert.Mileage = 10_000;
                    }
                    else
                    {
                        Console.WriteLine($"{carToRevert.Model} mileage decreased by {kilometers} kilometers");
                    }
                }

                commandLine = Console.ReadLine();
            }

            foreach (Car car in allCars)
            {
                Console.WriteLine(car);
            }
        }
    }

    public class Car
    {
        public Car(string model, int mileage, int fuel)
        {
            this.Model = model;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
        public override string ToString()
        {
            return $"{Model} -> Mileage: {Mileage} kms, Fuel in the tank: {Fuel} lt.";
        }
    }
}
