using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            Catalogue catalogue = new Catalogue();

            while (inputData != "end")
            {
                string[] tokens = inputData.Split("/", StringSplitOptions.RemoveEmptyEntries);
                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                int value = int.Parse(tokens[3]);

                switch (type)
                {
                    case "Car":
                        Car car = new Car();
                        car.Brand = brand;
                        car.Model = model;
                        car.HorsePower = value;
                        catalogue.Cars.Add(car);
                        break;

                    case "Truck":
                        Truck truck = new Truck();
                        truck.Brand = brand;
                        truck.Model = model;
                        truck.Weight = value;
                        catalogue.Trucks.Add(truck);
                        break;
                }

                inputData = Console.ReadLine();
            }

            if (catalogue.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in catalogue.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine(car);
                }
            }

            if (catalogue.Trucks.Count > 0)
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
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
