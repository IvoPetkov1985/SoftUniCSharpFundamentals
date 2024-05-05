using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int touristsCount = int.Parse(Console.ReadLine());

            int[] liftState = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int wagonCapacity = 4;
            bool areTouristsWaiting = true;

            for (int i = 0; i < liftState.Length; i++)
            {
                int currentDiff = wagonCapacity - liftState[i];

                if (touristsCount > currentDiff)
                {
                    liftState[i] += currentDiff;
                    touristsCount -= currentDiff;
                }
                else
                {
                    liftState[i] += touristsCount;

                    int sum = liftState.Sum();

                    if (sum < liftState.Length * wagonCapacity)
                    {
                        Console.WriteLine("The lift has empty spots!");
                        Console.WriteLine(string.Join(" ", liftState));
                    }
                    else
                    {
                        Console.WriteLine(string.Join(" ", liftState));
                    }

                    areTouristsWaiting = false;
                    break;
                }
            }

            if (areTouristsWaiting)
            {
                Console.WriteLine($"There isn't enough space! {touristsCount} people in a queue!");
                Console.WriteLine(string.Join(" ", liftState));
            }
        }
    }
}
