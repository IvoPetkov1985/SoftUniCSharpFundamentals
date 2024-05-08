using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequenceOfWords = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (string word in sequenceOfWords)
            {
                string currentWord = word.ToLower();

                if (!words.ContainsKey(currentWord))
                {
                    words.Add(currentWord, 0);
                }

                words[currentWord]++;
            }

            List<string> listOfWords = new List<string>();

            foreach (var (key, value) in words)
            {
                if (value % 2 != 0)
                {
                    listOfWords.Add(key);
                }
            }

            Console.WriteLine(string.Join(" ", listOfWords));
        }
    }
}
