using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _03._SoftUni_Bar_Income_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            string pattern = @"^%(?<custName>[A-Z][a-z]+)%[^\|\$\%\.]*?\<(?<product>\w+)\>[^\|\$\%\.]*?\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)?)\$$";

            decimal income = 0;

            while (inputLine != "end of shift")
            {
                Match match = Regex.Match(inputLine, pattern);

                if (match.Success)
                {
                    string customer = match.Groups["custName"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);

                    decimal custSum = count * price;
                    income += custSum;

                    Console.WriteLine($"{customer}: {product} - {custSum:F2}");
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {income:F2}");
        }
    }
}
