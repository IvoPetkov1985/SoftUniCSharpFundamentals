using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string operationLine = Console.ReadLine();

            while (true)
            {
                if (operationLine == "End")
                {
                    break;
                }

                string[] tokens = operationLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                switch (currentCommand)
                {
                    case "Add":

                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        break;

                    case "Insert":

                        int valueToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);

                        if (indexToInsert >= 0 && indexToInsert < numbers.Count)
                        {
                            numbers.Insert(indexToInsert, valueToInsert);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Remove":

                        int indexToRemove = int.Parse(tokens[1]);

                        if (indexToRemove >= 0 && indexToRemove < numbers.Count)
                        {
                            numbers.RemoveAt(indexToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Shift":

                        string direction = tokens[1];
                        int count = int.Parse(tokens[2]);

                        switch (direction)
                        {
                            case "left":

                                for (int i = 0; i < count; i++)
                                {
                                    int first = numbers[0];
                                    numbers.RemoveAt(0);
                                    numbers.Add(first);
                                }
                                break;

                            case "right":

                                for (int i = 0; i < count; i++)
                                {
                                    int last = numbers[numbers.Count - 1];
                                    numbers.RemoveAt(numbers.Count - 1);
                                    numbers.Insert(0, last);
                                }
                                break;
                        }
                        break;
                }

                operationLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
