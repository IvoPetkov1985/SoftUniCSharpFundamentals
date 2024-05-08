using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] words = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstWord = words[0];
            string secondWord = words[1];

            int minValue = Math.Min(firstWord.Length, secondWord.Length);

            int totalSum = 0;

            for (int i = 0; i < minValue; i++)
            {
                totalSum += firstWord[i] * secondWord[i];
            }

            if (firstWord.Length > secondWord.Length)
            {
                for (int i = minValue; i < firstWord.Length; i++)
                {
                    totalSum += firstWord[i];
                }
            }
            else
            {
                for (int i = minValue; i < secondWord.Length; i++)
                {
                    totalSum += secondWord[i];
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
