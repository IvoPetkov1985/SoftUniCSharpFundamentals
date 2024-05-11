using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(\@|\#)(?<word1>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1";

            MatchCollection validPairs = Regex.Matches(text, pattern);
            List<string> mirrors = new List<string>();

            foreach (Match match in validPairs)
            {
                if (match.Success)
                {
                    string firstWord = match.Groups["word1"].Value;
                    string secondWord = match.Groups["word2"].Value;
                    string reversed = new string(secondWord.Reverse().ToArray());

                    if (reversed == firstWord)
                    {
                        mirrors.Add($"{firstWord} <=> {secondWord}");
                    }
                }
            }

            if (validPairs.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{validPairs.Count} word pairs found!");
            }

            if (mirrors.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrors));
            }
        }
    }
}
