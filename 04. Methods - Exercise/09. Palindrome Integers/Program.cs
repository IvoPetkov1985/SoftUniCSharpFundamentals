using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                string currentNumAsText = command;
                string reversedNumAsText = string.Empty;

                for (int i = currentNumAsText.Length - 1; i >= 0; i--)
                {
                    string currentDigit = currentNumAsText[i].ToString();
                    reversedNumAsText += currentDigit;
                }

                if (currentNumAsText == reversedNumAsText)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                command = Console.ReadLine();
            }
        }
    }
}
