using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            StringBuilder encryptedText = new StringBuilder();

            foreach (char symbol in inputText)
            {
                char currentChar = (char)((char)symbol + 3);
                encryptedText.Append(currentChar);
            }

            Console.WriteLine(encryptedText.ToString());
        }
    }
}
