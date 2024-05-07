using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());

            int[] liftState = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < liftState.Length; i++)
            {
                if (liftState[i] < 4)
                {
                    while (liftState[i] < 4)
                    {
                        liftState[i]++;
                        peopleWaiting--;

                        if (peopleWaiting == 0)
                        {
                            break;
                        }
                    }

                    if (peopleWaiting == 0)
                    {
                        break;
                    }
                }
            }

            if (peopleWaiting == 0 && liftState.Any(x => x < 4))
            {
                Console.WriteLine("The lift has empty spots!");
            }
            else if (peopleWaiting > 0 && liftState.All(x => x == 4))
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            }

            Console.WriteLine(string.Join(" ", liftState));
        }
    }
}
