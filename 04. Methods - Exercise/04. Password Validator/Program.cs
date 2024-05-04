using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenPassword = Console.ReadLine();
            bool isLengthValid = ValidLength(givenPassword);
            bool areCharsValid = ValidChars(givenPassword);
            bool isNumbersCountValid = ValidNumsCount(givenPassword);

            if (!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!areCharsValid)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isNumbersCountValid)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isNumbersCountValid && areCharsValid && isNumbersCountValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool ValidLength(string pwd)
        {
            if (pwd.Length >= 6 && pwd.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ValidChars(string pwd)
        {
            for (int i = 0; i < pwd.Length; i++)
            {
                char current = pwd[i];

                if (!((current >= 48 && current <= 57) || (current >= 65 && current <= 90) ||
                    (current >= 97 && current <= 122)))
                {
                    return false;
                }
            }

            return true;
        }

        static bool ValidNumsCount(string pwd)
        {
            int counter = 0;

            for (int i = 0; i < pwd.Length; i++)
            {
                char currentChar = pwd[i];

                if (currentChar >= 48 && currentChar <= 57)
                {
                    counter++;
                }
            }

            if (counter < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
