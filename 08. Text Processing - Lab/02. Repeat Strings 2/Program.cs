using System;
using System.Text;

namespace _02._Repeat_Strings_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] words = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder builder = new StringBuilder();

            foreach (string currentWord in words)
            {
                for (int i = 0; i < currentWord.Length; i++)
                {
                    builder.Append(currentWord);
                }
            }

            Console.WriteLine(builder);
        }
    }
}
