using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            MatchCollection matchedNames = Regex.Matches(inputText, regex);

            foreach (Match item in matchedNames)
            {
                Console.Write(item.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
