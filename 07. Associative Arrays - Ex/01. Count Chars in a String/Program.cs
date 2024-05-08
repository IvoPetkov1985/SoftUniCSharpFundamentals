using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            Dictionary<char, int> charCounter = new Dictionary<char, int>();

            foreach (char symbol in inputText)
            {
                if (symbol == ' ')
                {
                    continue;
                }

                if (!charCounter.ContainsKey(symbol))
                {
                    charCounter.Add(symbol, 1);
                }
                else
                {
                    charCounter[symbol]++;
                }
            }

            foreach (KeyValuePair<char, int> kvp in charCounter)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
