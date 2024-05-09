using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _03._Match_Dates_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDates = Console.ReadLine();

            string pattern = @"\b(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            MatchCollection dates = Regex.Matches(inputDates, pattern);

            foreach (Match currentDate in dates)
            {
                string day = currentDate.Groups["day"].Value;
                string month = currentDate.Groups["month"].Value;
                string year = currentDate.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
