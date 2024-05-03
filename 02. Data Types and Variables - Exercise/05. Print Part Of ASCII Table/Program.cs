using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCharNum = int.Parse(Console.ReadLine());
            int secondCharNum = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = firstCharNum; i <= secondCharNum; i++)
            {
                char currentChar = (char)i;

                if (i == secondCharNum)
                {
                    result += currentChar;
                }
                else
                {
                    result += currentChar + " ";
                }
            }

            Console.WriteLine(result);
        }
    }
}
