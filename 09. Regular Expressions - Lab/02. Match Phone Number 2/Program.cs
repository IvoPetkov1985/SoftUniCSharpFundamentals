using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _02._Match_Phone_Number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\+\b359( |-)2\1\d{3}\1\d{4}\b";

            MatchCollection collection = Regex.Matches(input, pattern);

            List<string> validPhones = new List<string>();

            foreach (Match match in collection)
            {
                validPhones.Add(match.Value);
            }

            Console.WriteLine(string.Join(", ", validPhones));
        }
    }
}
