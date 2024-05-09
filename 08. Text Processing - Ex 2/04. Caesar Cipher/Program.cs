using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder encrypted = new StringBuilder();

            foreach (char symbol in text)
            {
                int currentSymbolCode = (int)symbol + 3;
                char newChar = (char)currentSymbolCode;
                encrypted.Append(newChar);
            }

            Console.WriteLine(encrypted.ToString());
        }
    }
}
