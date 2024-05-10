using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(=|\/)([A-Z][A-z]{2,})\1";

            MatchCollection matches = Regex.Matches(input, pattern);

            int travelPoints = 0;
            List<string> destinations = new List<string>();

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    string destination = match.Groups[2].Value;
                    destinations.Add(destination);
                    travelPoints += destination.Length;
                }
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
