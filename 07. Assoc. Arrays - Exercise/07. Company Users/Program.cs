using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, List<string>> companiesInfo = new Dictionary<string, List<string>>();

            while (inputLine != "End")
            {
                string[] tokens = inputLine.Split(" -> ");
                string companyName = tokens[0];
                string employee = tokens[1];

                if (!companiesInfo.ContainsKey(companyName))
                {
                    companiesInfo[companyName] = new List<string>();
                }

                if (!companiesInfo[companyName].Contains(employee))
                {
                    companiesInfo[companyName].Add(employee);
                }

                inputLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> kvp in companiesInfo)
            {
                string company = kvp.Key;
                List<string> employees = kvp.Value;

                Console.WriteLine(company);

                employees.ForEach(x => Console.WriteLine($"-- {x}"));
            }
        }
    }
}
