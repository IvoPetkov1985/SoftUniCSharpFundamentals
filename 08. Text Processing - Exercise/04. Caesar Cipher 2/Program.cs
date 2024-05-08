using System;
using System.Text;

namespace _04._Caesar_Cipher_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            StringBuilder resultLine = new StringBuilder();

            for (int i = 0; i < inputText.Length; i++)
            {
                int currentValue = inputText[i];
                currentValue += 3;
                char charToAppend = (char)currentValue;
                resultLine.Append(charToAppend);
            }

            Console.WriteLine(resultLine.ToString());
        }
    }
}
