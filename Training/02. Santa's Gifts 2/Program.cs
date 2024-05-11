using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Santa_s_Gifts_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<int> houseNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int position = 0;

            for (int i = 0; i < count; i++)
            {
                string inputLine = Console.ReadLine();
                string[] cmdArgs = inputLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs.First();

                switch (command)
                {
                    case "Forward":
                        int stepsForward = int.Parse(cmdArgs.Last());

                        if (position + stepsForward < houseNumbers.Count)
                        {
                            position += stepsForward;
                            houseNumbers.RemoveAt(position);
                        }
                        break;

                    case "Back":
                        int stepsBack = int.Parse(cmdArgs.Last());

                        if (position - stepsBack >= 0)
                        {
                            position -= stepsBack;
                            houseNumbers.RemoveAt(position);
                        }
                        break;

                    case "Gift":
                        int index = int.Parse(cmdArgs[1]);
                        int newHouseNumber = int.Parse(cmdArgs.Last());

                        if (index >= 0 && index < houseNumbers.Count)
                        {
                            houseNumbers.Insert(index, newHouseNumber);
                            position = index;
                        }
                        break;

                    case "Swap":
                        int firstValue = int.Parse(cmdArgs[1]);
                        int secondValue = int.Parse(cmdArgs.Last());

                        int firstValueIndex = houseNumbers.IndexOf(firstValue);
                        int secondValueIndex = houseNumbers.IndexOf(secondValue);

                        if (firstValueIndex != -1 && secondValueIndex != -1)
                        {
                            houseNumbers[firstValueIndex] = secondValue;
                            houseNumbers[secondValueIndex] = firstValue;
                        }
                        break;
                }
            }

            Console.WriteLine($"Position: {position}");
            Console.WriteLine(string.Join(", ", houseNumbers));
        }
    }
}
