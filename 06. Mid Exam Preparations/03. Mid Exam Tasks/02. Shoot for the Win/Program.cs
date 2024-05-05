using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            int counter = 0;

            while (command != "End")
            {
                int index = int.Parse(command);

                if (index >= 0 && index < targets.Length)
                {
                    if (targets[index] != -1)
                    {
                        counter++;
                        int currentValue = targets[index];
                        targets[index] = -1;

                        for (int i = 0; i < targets.Length; i++)
                        {
                            if (targets[i] > currentValue && targets[i] != -1)
                            {
                                targets[i] -= currentValue;
                            }
                            else if (targets[i] <= currentValue && targets[i] != -1)
                            {
                                targets[i] += currentValue;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", targets)}");
        }
    }
}
