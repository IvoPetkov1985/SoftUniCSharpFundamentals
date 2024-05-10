using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> carsCollection = new Dictionary<string, int[]>();

            for (int i = 0; i < carsCount; i++)
            {
                string inputLine = Console.ReadLine();
                string[] carDetails = inputLine.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string carName = carDetails.First();
                int mileage = int.Parse(carDetails[1]);
                int fuel = int.Parse(carDetails.Last());

                if (!carsCollection.ContainsKey(carName))
                {
                    carsCollection.Add(carName, new int[2]);
                    carsCollection[carName][0] = mileage;
                    carsCollection[carName][1] = fuel;
                }
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Stop")
            {
                string[] cmdArgs = commandLine.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs.First();
                string car = cmdArgs[1];

                switch (command)
                {
                    case "Drive":
                        int distance = int.Parse(cmdArgs[2]);
                        int fuelToBurn = int.Parse(cmdArgs.Last());

                        if (carsCollection[car][1] >= fuelToBurn)
                        {
                            carsCollection[car][0] += distance;
                            carsCollection[car][1] -= fuelToBurn;
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuelToBurn} liters of fuel consumed.");
                        }
                        else
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }

                        if (carsCollection[car][0] > 100_000)
                        {
                            carsCollection.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                        break;

                    case "Refuel":
                        int freshFuel = int.Parse(cmdArgs.Last());
                        int oldFuelValue = carsCollection[car][1];

                        carsCollection[car][1] += freshFuel;

                        if (carsCollection[car][1] > 75)
                        {
                            carsCollection[car][1] = 75;
                            Console.WriteLine($"{car} refueled with {75 - oldFuelValue} liters");
                        }
                        else
                        {
                            Console.WriteLine($"{car} refueled with {freshFuel} liters");
                        }
                        break;

                    case "Revert":
                        int kilometers = int.Parse(cmdArgs.Last());

                        carsCollection[car][0] -= kilometers;

                        if (carsCollection[car][0] >= 10_000)
                        {
                            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                        }
                        else
                        {
                            carsCollection[car][0] = 10_000;
                        }
                        break;
                }

                commandLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int[]> carDetails in carsCollection)
            {
                string car = carDetails.Key;
                int mileage = carDetails.Value[0];
                int fuelQty = carDetails.Value[1];

                Console.WriteLine($"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuelQty} lt.");
            }
        }
    }
}
