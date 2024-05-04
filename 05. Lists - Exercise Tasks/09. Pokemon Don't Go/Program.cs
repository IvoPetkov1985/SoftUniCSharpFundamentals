using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int removedElementsSum = 0;

            while (true)
            {
                if (!sequence.Any())
                {
                    Console.WriteLine(removedElementsSum);
                    break;
                }

                int index = int.Parse(Console.ReadLine());

                if (index >= 0 && index < sequence.Count)
                {
                    int elementToRemove = sequence[index];
                    removedElementsSum += elementToRemove;
                    sequence.RemoveAt(index);

                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] <= elementToRemove)
                        {
                            sequence[i] += elementToRemove;
                        }
                        else
                        {
                            sequence[i] -= elementToRemove;
                        }
                    }
                }
                else if (index < 0)
                {
                    int valueToDel = sequence[0];
                    removedElementsSum += valueToDel;
                    sequence[0] = sequence[sequence.Count - 1];

                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] <= valueToDel)
                        {
                            sequence[i] += valueToDel;
                        }
                        else
                        {
                            sequence[i] -= valueToDel;
                        }
                    }
                }
                else if (index >= sequence.Count)
                {
                    int valueToDel = sequence[sequence.Count - 1];
                    removedElementsSum += valueToDel;
                    sequence[sequence.Count - 1] = sequence[0];

                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] <= valueToDel)
                        {
                            sequence[i] += valueToDel;
                        }
                        else
                        {
                            sequence[i] -= valueToDel;
                        }
                    }
                }
            }
        }
    }
}
