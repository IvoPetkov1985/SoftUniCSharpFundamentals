using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();            

            while (command != "End")
            {
                int index = int.Parse(command);

                if ((index >= 0 && index < targets.Length) && targets[index] != -1)
                {
                    int value = targets[index];
                    targets[index] = -1;

                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] > value && targets[i] != -1)
                        {
                            targets[i] -= value;
                        }
                        else if (targets[i] <= value && targets[i] != -1)
                        {
                            targets[i] += value;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            int shotTargets = targets.Where(x => x == -1).Count();
            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", targets)}");
        }
    }
}
