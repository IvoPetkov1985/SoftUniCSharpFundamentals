using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Destination_Mapper_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            string pattern = @"(=|\/)(?<country>[A-Z][A-Za-z]{2,})\1";

            MatchCollection destinations = Regex.Matches(inputLine, pattern);
            int travelPoints = 0;
            List<string> countries = new List<string>();

            foreach (Match destination in destinations)
            {
                string country = destination.Groups["country"].Value;
                travelPoints += country.Length;
                countries.Add(country);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", countries)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
