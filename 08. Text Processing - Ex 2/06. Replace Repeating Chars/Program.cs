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

            char currentSymbol = inputLine[0];
            resultLine.Append(currentSymbol);

            for (int i = 1; i < inputLine.Length; i++)
            {
                char symbol = inputLine[i];

                if (symbol != currentSymbol)
                {
                    currentSymbol = symbol;
                    resultLine.Append(currentSymbol);
                }
            }

            Console.WriteLine(resultLine.ToString());
        }
    }
}
