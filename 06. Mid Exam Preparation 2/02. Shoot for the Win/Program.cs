using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targetsSequence = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            string commandLine = Console.ReadLine();
            int shootsCounter = 0;

            while (commandLine != "End")
            {
                int indexToShoot = int.Parse(commandLine);

                if (indexToShoot >= 0 && indexToShoot < targetsSequence.Length)
                {
                    if (targetsSequence[indexToShoot] != -1)
                    {
                        shootsCounter++;
                        int shotElement = targetsSequence[indexToShoot];
                        targetsSequence[indexToShoot] = -1;

                        for (int i = 0; i < targetsSequence.Length; i++)
                        {
                            if (targetsSequence[i] != -1)
                            {
                                if (targetsSequence[i] > shotElement)
                                {
                                    targetsSequence[i] -= shotElement;
                                }
                                else
                                {
                                    targetsSequence[i] += shotElement;
                                }
                            }
                        }
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shootsCounter} -> {string.Join(" ", targetsSequence)}");
        }
    }
}
