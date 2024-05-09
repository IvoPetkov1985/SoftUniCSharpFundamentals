using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+\b359(-| )2\1\d{3}\1\d{4}\b";

            string inputLine = Console.ReadLine();

            MatchCollection matchedPhones = Regex.Matches(inputLine, regex);

            List<string> phones = new List<string>();

            foreach (Match phone in matchedPhones)
            {
                phones.Add(phone.Value);
            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
