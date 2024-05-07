using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Catalogue catalogue = new Catalogue();

            while (inputLine != "end")
            {
                string[] vehicleTokens = inputLine.Split("/");
                string type = vehicleTokens[0];
                string brand = vehicleTokens[1];
                string model = vehicleTokens[2];
                int value = int.Parse(vehicleTokens[3]);

                if (type == "Car")
                {
                    Car car = new Car(brand, model, value);
                    catalogue.Cars.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck(brand, model, value);
                    catalogue.Trucks.Add(truck);
                }

                inputLine = Console.ReadLine();
            }

            if (catalogue.Cars.Any())
            {
                Console.WriteLine("Cars:");

                foreach (Car car in catalogue.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine(car);
                }
            }

            if (catalogue.Trucks.Any())
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in catalogue.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine(truck);
                }
            }
        }
    }

    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
        public override string ToString()
        {
            return $"{Brand}: {Model} - {Weight}kg";
        }
    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public override string ToString()
        {
            return $"{Brand}: {Model} - {HorsePower}hp";
        }
    }

    public class Catalogue
    {
        public Catalogue()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
}
