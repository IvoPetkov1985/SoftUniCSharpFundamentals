using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string emojiPattern = @"(\:{2}|\*{2})([A-Z][a-z]{2,})\1";
            string digitPattern = @"\d";

            List<int> digitsInTheText = new List<int>();

            MatchCollection digits = Regex.Matches(input, digitPattern);

            foreach (Match match in digits)
            {
                if (match.Success)
                {
                    int num = int.Parse(match.Value);
                    digitsInTheText.Add(num);
                }
            }

            BigInteger treshold = 0;

            if (digitsInTheText.Count > 1)
            {
                treshold = digitsInTheText[0];

                for (int i = 1; i < digitsInTheText.Count; i++)
                {
                    treshold *= digitsInTheText[i];
                }
            }
            else if (digitsInTheText.Count == 1)
            {
                treshold = digitsInTheText[0];
            }
            else
            {
                treshold = 0;
            }

            Console.WriteLine($"Cool threshold: {treshold}");

            MatchCollection emojis = Regex.Matches(input, emojiPattern);

            List<string> coolEmojis = new List<string>();

            foreach (Match emoji in emojis)
            {
                int emojiSum = 0;

                if (emoji.Success)
                {
                    string emojiName = emoji.Value;

                    foreach (char letter in emojiName)
                    {
                        if (char.IsLetter(letter))
                        {
                            emojiSum += letter;
                        }
                    }

                    if (emojiSum > treshold)
                    {
                        coolEmojis.Add(emojiName);
                    }
                }
            }

            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join(Environment.NewLine, coolEmojis));
        }
    }
}
