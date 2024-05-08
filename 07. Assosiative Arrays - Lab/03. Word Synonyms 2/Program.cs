using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Word_Synonyms_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordsDict = new Dictionary<string, List<string>>();

            for (int i = 0; i < wordsCount; i++)
            {
                string currentWord = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordsDict.ContainsKey(currentWord))
                {
                    wordsDict.Add(currentWord, new List<string>());
                }

                wordsDict[currentWord].Add(synonym);
            }

            foreach (var kvp in wordsDict)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
