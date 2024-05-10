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
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string infoLine = Console.ReadLine();
                string[] carDetails = infoLine.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string carName = carDetails[0];
                int mileage = int.Parse(carDetails[1]);
                int fuel = int.Parse(carDetails[2]);
                Car car = new Car(carName, mileage, fuel);
                cars.Add(car);
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Stop")
            {
                string[] tokens = commandLine.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string carName = tokens[1];

                if (command == "Drive")
                {
                    int distance = int.Parse(tokens[2]);
                    int fuel = int.Parse(tokens[3]);

                    Car carToDrive = cars.Find(x => x.Model == carName);
                    if (carToDrive.Fuel < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        carToDrive.Mileage += distance;
                        carToDrive.Fuel -= fuel;
                        Console.WriteLine($"{carToDrive.Model} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }

                    if (carToDrive.Mileage > 100000)
                    {
                        cars.Remove(carToDrive);
                        Console.WriteLine($"Time to sell the {carToDrive.Model}!");
                    }
                }
                else if (command == "Refuel")
                {
                    int freshFuel = int.Parse(tokens[2]);

                    Car carToRefuel = cars.Find(x => x.Model == carName);
                    int oldQuantity = carToRefuel.Fuel;
                    carToRefuel.Fuel += freshFuel;

                    if (carToRefuel.Fuel > 75)
                    {
                        carToRefuel.Fuel = 75;
                        Console.WriteLine($"{carToRefuel.Model} refueled with {75 - oldQuantity} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{carToRefuel.Model} refueled with {freshFuel} liters");
                    }
                }
                else if (command == "Revert")
                {
                    int kilometers = int.Parse(tokens[2]);

                    Car carToRevert = cars.Find(x => x.Model == carName);
                    carToRevert.Mileage -= kilometers;

                    if (carToRevert.Mileage >= 10000)
                    {
                        Console.WriteLine($"{carToRevert.Model} mileage decreased by {kilometers} kilometers");
                    }
                    else
                    {
                        carToRevert.Mileage = 10000;
                    }
                }

                commandLine = Console.ReadLine();
            }

            foreach (Car car in cars)
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
