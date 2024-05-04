using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string result = ConcatenateString(input, count);
            Console.WriteLine(result);
        }

        static string ConcatenateString(string word, int times)
        {
            string resultString = string.Empty;

            for (int i = 0; i < times; i++)
            {
                resultString += word;
            }

            return resultString;
        }
    }
}
