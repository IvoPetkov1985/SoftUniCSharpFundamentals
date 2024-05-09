using System;
using System.Text;
using System.Linq;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfWords = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();

            foreach (string currentWord in arrayOfWords)
            {
                for (int i = 0; i < currentWord.Length; i++)
                {
                    result.Append(currentWord);
                }
            }

            Console.WriteLine(result);
        }
    }
}
