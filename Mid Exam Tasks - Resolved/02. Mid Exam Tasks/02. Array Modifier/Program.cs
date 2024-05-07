using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string commandLine = Console.ReadLine();

            while (commandLine != "end")
            {
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                switch (command)
                {
                    case "swap":
                        int index1 = int.Parse(tokens[1]);
                        int index2 = int.Parse(tokens[2]);
                        int buff = sequence[index1];
                        sequence[index1] = sequence[index2];
                        sequence[index2] = buff;
                        break;

                    case "multiply":
                        int firstIndex = int.Parse(tokens[1]);
                        int secondIndex = int.Parse(tokens[2]);
                        sequence[firstIndex] *= sequence[secondIndex];
                        break;

                    case "decrease":
                        sequence = sequence.Select(x => x - 1).ToArray();
                        break;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
