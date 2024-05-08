using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Text_Filter_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ' ', ',' };
            string[] bannedWords = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (string word in bannedWords)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
