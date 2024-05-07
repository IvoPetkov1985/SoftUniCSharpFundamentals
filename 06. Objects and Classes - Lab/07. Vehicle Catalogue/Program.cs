using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            Catalog catalog = new Catalog();

            while (inputLine != "end")
            {
                string[] vehicleInfo = inputLine.Split("/");

                string type = vehicleInfo[0];
                string brand = vehicleInfo[1];
                string model = vehicleInfo[2];
                int value = int.Parse(vehicleInfo[3]);

                switch (type)
                {
                    case "Car":
                        Car car = new Car();
                        car.Brand = brand;
                        car.Model = model;
                        car.HorsePower = value;
                        catalog.Cars.Add(car);

                        break;

                    case "Truck":
                        Truck truck = new Truck();
                        truck.Brand = brand;
                        truck.Model = model;
                        truck.Weight = value;
                        catalog.Trucks.Add(truck);
                        break;
                }

                inputLine = Console.ReadLine();
            }

            if (catalog.Cars.Any())
            {
                Console.WriteLine("Cars:");
            }

            foreach (Car car in catalog.Cars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            if (catalog.Trucks.Any())
            {
                Console.WriteLine("Trucks:");
            }

            foreach (Truck truck in catalog.Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
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

    public class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
