using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _02._Race_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string patternNames = @"[A-Za-z]+";
            string patternDigits = @"\d";

            Dictionary<string, int> runners = new Dictionary<string, int>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end of race")
            {
                StringBuilder currentName = new StringBuilder();
                int currentKm = 0;

                MatchCollection letterMatches = Regex.Matches(inputLine, patternNames);
                foreach (Match letter in letterMatches)
                {
                    currentName.Append(letter.Value);
                }

                MatchCollection digits = Regex.Matches(inputLine, patternDigits);
                foreach (Match digit in digits)
                {
                    currentKm += int.Parse(digit.Value);
                }

                string newName = currentName.ToString();

                if (names.Contains(newName) && !runners.ContainsKey(newName))
                {
                    runners.Add(newName, currentKm);
                }
                else if (runners.ContainsKey(newName))
                {
                    runners[newName] += currentKm;
                }

                inputLine = Console.ReadLine();
            }

            int place = 0;

            foreach (var runner in runners.OrderByDescending(x => x.Value))
            {
                place++;

                if (place > 3)
                {
                    break;
                }

                if (place == 1)
                {
                    Console.WriteLine($"1st place: {runner.Key}");
                }
                else if (place == 2)
                {
                    Console.WriteLine($"2nd place: {runner.Key}");
                }
                else if (place == 3)
                {
                    Console.WriteLine($"3rd place: {runner.Key}");
                }
            }
        }
    }
}
