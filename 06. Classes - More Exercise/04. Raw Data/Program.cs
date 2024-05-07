using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> carsList = new List<Car>();

            for (int i = 1; i <= carsCount; i++)
            {
                string[] carTokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carTokens[0];
                int engineSpeed = int.Parse(carTokens[1]);
                int enginePower = int.Parse(carTokens[2]);
                int cargoWeight = int.Parse(carTokens[3]);
                string cargoType = carTokens[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, cargo);
                carsList.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<Car> filtered = carsList.FindAll(x => x.Cargo.Type == "fragile" && x.Cargo.Weight < 1000);
                filtered.ForEach(x => Console.WriteLine(x));
            }
            else if (command == "flamable")
            {
                List<Car> filteredList = carsList.FindAll(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250);
                filteredList.ForEach(x => Console.WriteLine(x));
            }
        }
    }

    public class Engine
    {
        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }
        public int Speed { get; set; }
        public int Power { get; set; }
    }

    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
        public int Weight { get; set; }
        public string Type { get; set; }
    }

    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public override string ToString()
        {
            return Model;
        }
    }
}
