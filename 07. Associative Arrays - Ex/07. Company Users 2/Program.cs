using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, List<string>> register = new Dictionary<string, List<string>>();

            while (inputLine != "End")
            {
                string[] tokens = inputLine.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string company = tokens[0];
                string employeeID = tokens[1];

                if (!register.ContainsKey(company))
                {
                    register[company] = new List<string>();
                }

                if (!register[company].Contains(employeeID))
                {
                    register[company].Add(employeeID);
                }

                inputLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> kvp in register)
            {
                string comapanyName = kvp.Key;
                List<string> employees = kvp.Value;
                Console.WriteLine(comapanyName);

                foreach (string employee in employees)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
