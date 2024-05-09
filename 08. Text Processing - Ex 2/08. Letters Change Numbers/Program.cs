using System;
using System.Text;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] sequences = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0.0;

            for (int i = 0; i < sequences.Length; i++)
            {
                string currentSequence = sequences[i];
                double currentSum = 0.0;

                char firstLetter = currentSequence[0];

                StringBuilder numAsText = new StringBuilder();

                for (int j = 1; j < currentSequence.Length - 1; j++)
                {
                    numAsText.Append(currentSequence[j]);
                }

                double currentNum = double.Parse(numAsText.ToString());
                char lastLetter = currentSequence[^1];

                if (char.IsUpper(firstLetter))
                {
                    int position = firstLetter - 64;
                    currentSum += currentNum / position;
                }
                else if (char.IsLower(firstLetter))
                {
                    int position = firstLetter - 96;
                    currentSum += currentNum * position;
                }

                if (char.IsUpper(lastLetter))
                {
                    int position = lastLetter - 64;
                    currentSum -= position;
                }
                else if (char.IsLower(lastLetter))
                {
                    int position = lastLetter - 96;
                    currentSum += position;
                }

                sum += currentSum;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
