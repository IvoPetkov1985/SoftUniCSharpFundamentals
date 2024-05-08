using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentText = Console.ReadLine();

            Dictionary<char, int> charCounter = new Dictionary<char, int>();

            foreach (char symbol in currentText)
            {
                if (symbol == ' ')
                {
                    continue;
                }

                if (!charCounter.ContainsKey(symbol))
                {
                    charCounter[symbol] = 0;
                }

                charCounter[symbol]++;
            }

            foreach (KeyValuePair<char, int> kvp in charCounter)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
