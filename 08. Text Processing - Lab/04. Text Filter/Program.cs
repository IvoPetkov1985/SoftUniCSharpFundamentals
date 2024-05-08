using System;
using System.Text;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            string[] bannedWords = words.Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (string banned in bannedWords)
            {
                if (text.Contains(banned))
                {
                    text = text.Replace(banned, new string('*', banned.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
