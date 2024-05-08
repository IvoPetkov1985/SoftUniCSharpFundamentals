using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequenceOfWords = Console.ReadLine().Split(" ");

            Dictionary<string, int> wordOccurrences = new Dictionary<string, int>();

            foreach (string word in sequenceOfWords)
            {
                string wordToLower = word.ToLower();

                if (!wordOccurrences.ContainsKey(wordToLower))
                {
                    wordOccurrences.Add(wordToLower, 1);
                }
                else
                {
                    wordOccurrences[wordToLower]++;
                }
            }

            string result = string.Empty;

            foreach (var (key, value) in wordOccurrences)
            {
                if (value % 2 == 1)
                {
                    result += key + " ";
                }
            }

            Console.WriteLine(result.Trim());
        }
    }
}
