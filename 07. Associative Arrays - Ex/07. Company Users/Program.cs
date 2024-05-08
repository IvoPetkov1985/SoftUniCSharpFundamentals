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
                string[] tokens = inputLine.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string comapanyName = tokens[0];
                string employeeID = tokens[1];

                if (!companiesInfo.ContainsKey(comapanyName))
                {
                    companiesInfo[comapanyName] = new List<string>();
                }

                if (!companiesInfo[comapanyName].Contains(employeeID))
                {
                    companiesInfo[comapanyName].Add(employeeID);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var (key, value) in companiesInfo)
            {
                Console.WriteLine(key);

                foreach (string name in value)
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
