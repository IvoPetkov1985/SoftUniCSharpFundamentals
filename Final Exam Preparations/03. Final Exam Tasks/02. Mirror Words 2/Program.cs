using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Mirror_Words_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            string pattern = @"(\@|#)(?<first>[A-Za-z]{3,})\1\1(?<last>[A-Za-z]{3,})\1";

            MatchCollection matches = Regex.Matches(inputText, pattern);
            List<string> mirrors = new List<string>();

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    string firstWord = match.Groups["first"].Value;
                    string secondWord = match.Groups["last"].Value;
                    string reversed = new string(secondWord.Reverse().ToArray());

                    if (reversed == firstWord)
                    {
                        mirrors.Add($"{firstWord} <=> {secondWord}");
                    }
                }
            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
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
