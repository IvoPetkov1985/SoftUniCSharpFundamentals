using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _01._Match_Full_Name_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string inputLine = Console.ReadLine();

            MatchCollection matches = Regex.Matches(inputLine, pattern);

            List<string> names = new List<string>();

            foreach (Match match in matches)
            {
                names.Add(match.ToString());
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
