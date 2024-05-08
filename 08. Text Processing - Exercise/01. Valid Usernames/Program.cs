using System;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] userNames = inputLine.Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string name in userNames)
            {
                if (IsNameValid(name))
                {
                    Console.WriteLine(name);
                }
            }
        }

        static bool IsNameValid(string username)
        {
            if (!(username.Length >= 3 && username.Length <= 16))
            {
                return false;
            }

            foreach (char symbol in username)
            {
                if (!(symbol == '-' || symbol == '_'
                    || char.IsLetterOrDigit(symbol)))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
