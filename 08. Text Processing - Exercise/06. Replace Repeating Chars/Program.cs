using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            StringBuilder resultLine = new StringBuilder();

            char currentChar = inputLine[0];
            resultLine.Append(currentChar);

            for (int i = 1; i < inputLine.Length; i++)
            {
                if (inputLine[i] != currentChar)
                {
                    currentChar = inputLine[i];
                    resultLine.Append(currentChar);
                }
            }

            Console.WriteLine(resultLine.ToString());
        }
    }
}
