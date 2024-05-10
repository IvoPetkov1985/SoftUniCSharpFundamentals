using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> carsCollection = new Dictionary<string, int[]>();

            for (int i = 1; i <= carsCount; i++)
            {
                string carInfo = Console.ReadLine();
                string[] carTokens = carInfo.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string model = carTokens[0];
                int mileage = int.Parse(carTokens[1]);
                int fuel = int.Parse(carTokens[2]);

                if (!carsCollection.ContainsKey(model))
                {
                    carsCollection.Add(model, new int[2]);
                    carsCollection[model][0] = mileage;
                    carsCollection[model][1] = fuel;
                }
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Stop")
            {
                string[] tokens = commandLine.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string car = tokens[1];

                switch (command)
                {
                    case "Drive":
                        int distance = int.Parse(tokens[2]);
                        int fuel = int.Parse(tokens[3]);

                        if (carsCollection[car][1] >= fuel)
                        {
                            carsCollection[car][0] += distance;
                            carsCollection[car][1] -= fuel;
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }
                        else
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }

                        if (carsCollection[car][0] > 100000)
                        {
                            carsCollection.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                        break;

                    case "Refuel":
                        int freshFuel = int.Parse(tokens[2]);
                        int oldQuantity = carsCollection[car][1];
                        carsCollection[car][1] += freshFuel;

                        if (carsCollection[car][1] > 75)
                        {
                            carsCollection[car][1] = 75;
                            Console.WriteLine($"{car} refueled with {75 - oldQuantity} liters");
                        }
                        else
                        {
                            Console.WriteLine($"{car} refueled with {freshFuel} liters");
                        }
                        break;

                    case "Revert":
                        int kilometers = int.Parse(tokens[2]);
                        carsCollection[car][0] -= kilometers;

                        if (carsCollection[car][0] > 10000)
                        {
                            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                        }
                        else
                        {
                            carsCollection[car][0] = 10000;
                        }
                        break;
                }

                commandLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int[]> kvp in carsCollection)
            {
                string car = kvp.Key;
                int mileage = kvp.Value[0];
                int fuel = kvp.Value[1];

                Console.WriteLine($"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt.");
            }
        }
    }
}
