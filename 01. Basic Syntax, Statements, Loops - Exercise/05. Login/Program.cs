using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currentCh = username[i];
                password += currentCh;
            }

            string currentPassword;
            int counter = 0;

            while ((currentPassword = Console.ReadLine()) != password)
            {
                counter++;

                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }

            if (currentPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
