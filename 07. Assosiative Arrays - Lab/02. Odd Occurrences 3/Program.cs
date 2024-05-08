using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequenceOfWords = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            foreach (string word in sequenceOfWords)
            {
                string currentWord = word.ToLower();

                if (!occurrences.ContainsKey(currentWord))
                {
                    occurrences[currentWord] = 1;
                }
                else
                {
                    occurrences[currentWord]++;
                }
            }

            foreach (KeyValuePair<string, int> kvp in occurrences)
            {
                if (kvp.Value % 2 == 1)
                {
                    Console.Write(kvp.Key + " ");
                }
            }
        }
    }
}
