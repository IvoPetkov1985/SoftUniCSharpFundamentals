using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] words = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0.0;

            foreach (string word in words)
            {
                char firstLetter = word[0];
                char secondLetter = word[^1];
                double numberBetween = double.Parse(word[1..^1].ToString());

                if (char.IsUpper(firstLetter))
                {
                    int position = firstLetter - 64;
                    numberBetween /= position;
                }
                else
                {
                    int position = firstLetter - 96;
                    numberBetween *= position;
                }

                if (char.IsUpper(secondLetter))
                {
                    int position = secondLetter - 64;
                    numberBetween -= position;
                }
                else
                {
                    int position = secondLetter - 96;
                    numberBetween += position;
                }

                sum += numberBetween;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
