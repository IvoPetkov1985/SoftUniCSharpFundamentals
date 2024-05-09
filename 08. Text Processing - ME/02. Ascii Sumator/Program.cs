using System;
using System.Text;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            string inputLine = Console.ReadLine();

            StringBuilder resultLine = new StringBuilder();

            for (int i = 0; i < inputLine.Length; i++)
            {
                if (firstChar < secondChar && inputLine[i] > firstChar && inputLine[i] < secondChar)
                {
                    resultLine.Append(inputLine[i]);
                }
                else if (firstChar > secondChar && inputLine[i] < firstChar && inputLine[i] > secondChar)
                {
                    resultLine.Append(inputLine[i]);
                }
            }

            int sum = 0;

            foreach (char symbol in resultLine.ToString())
            {
                sum += symbol;
            }

            Console.WriteLine(sum);
        }
    }
}
