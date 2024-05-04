using System;

namespace _09._Palindrome_Integers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (true)
            {
                if (command == "END")
                {
                    break;
                }

                string numAsText = command;

                Console.WriteLine(IsPalindrome(numAsText).ToString().ToLower());

                command = Console.ReadLine();
            }
        }

        static bool IsPalindrome(string numberAsText)
        {
            string reversed = String.Empty;

            for (int i = numberAsText.Length - 1; i >= 0; i--)
            {
                reversed += numberAsText[i].ToString();
            }

            if (numberAsText == reversed)
            {
                return true;
            }

            return false;
        }
    }
}
