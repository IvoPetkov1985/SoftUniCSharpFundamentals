using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(@|#)*?(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";
            List<string> validPairs = new List<string>();

            MatchCollection matchCollection = Regex.Matches(input, pattern);

            foreach (Match pair in matchCollection)
            {
                if (pair.Success)
                {
                    string firstWord = pair.Groups["first"].Value;
                    string secondWord = pair.Groups["second"].Value;
                    string reversedWord = new string(secondWord.Reverse().ToArray());

                    if (reversedWord == firstWord)
                    {
                        validPairs.Add($"{firstWord} <=> {secondWord}");
                    }
                }
            }

            if (matchCollection.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matchCollection.Count} word pairs found!");
            }

            if (validPairs.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", validPairs));
            }
        }
    }
}
