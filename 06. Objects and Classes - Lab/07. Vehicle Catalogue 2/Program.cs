using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Vehicle_Catalogue_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            Catalogue catalogue = new Catalogue();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split("/");

                string vehicleType = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                int value = int.Parse(tokens[3]);

                if (vehicleType == "Car")
                {
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = value;
                    catalogue.Cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = value;
                    catalogue.Trucks.Add(truck);
                }

                inputLine = Console.ReadLine();
            }

            if (catalogue.Cars.Any())
            {
                Console.WriteLine("Cars:");

                foreach (Car vehicle in catalogue.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{vehicle.Brand}: {vehicle.Model} - {vehicle.HorsePower}hp");
                }
            }

            if (catalogue.Trucks.Any())
            {
                Console.WriteLine("Trucks:");

                foreach (Truck vehicle in catalogue.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{vehicle.Brand}: {vehicle.Model} - {vehicle.Weight}kg");
                }
            }
        }
    }

    public class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    public class Catalogue
    {
        public Catalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }
}
