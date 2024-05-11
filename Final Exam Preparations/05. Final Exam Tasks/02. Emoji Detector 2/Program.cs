using System;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _02._Emoji_Detector_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string emojiPattern = @"(\:{2}|\*{2})(?<emojiName>[A-Z][a-z]{2,})\1";
            string digitPattern = @"\d";

            BigInteger threshold = 1;

            MatchCollection allDigits = Regex.Matches(input, digitPattern);

            foreach (Match singleDigit in allDigits)
            {
                if (singleDigit.Success)
                {
                    int num = int.Parse(singleDigit.Value);
                    threshold *= num;
                }
            }

            Console.WriteLine($"Cool threshold: {threshold}");

            MatchCollection validEmojis = Regex.Matches(input, emojiPattern);

            Console.WriteLine($"{validEmojis.Count} emojis found in the text. The cool ones are:");

            foreach (Match validEmoji in validEmojis)
            {
                int emojiSum = 0;

                if (validEmoji.Success)
                {
                    string emojiText = validEmoji.Groups["emojiName"].Value;

                    foreach (char letter in emojiText)
                    {
                        emojiSum += letter;
                    }

                    if (emojiSum > threshold)
                    {
                        Console.WriteLine(validEmoji);
                    }
                }
            }
        }
    }
}
