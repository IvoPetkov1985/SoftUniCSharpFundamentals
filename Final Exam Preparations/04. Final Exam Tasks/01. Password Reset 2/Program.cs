using System;
using System.Text;

namespace _01._Password_Reset_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string commandLine = Console.ReadLine();

            while (commandLine != "Done")
            {
                string[] instructions = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = instructions[0];

                switch (command)
                {
                    case "TakeOdd":
                        StringBuilder concatenated = new StringBuilder();

                        for (int i = 0; i < password.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                concatenated.Append(password[i]);
                            }
                        }

                        string result = concatenated.ToString();
                        password = result;
                        Console.WriteLine(password);
                        break;

                    case "Cut":
                        int index = int.Parse(instructions[1]);
                        int length = int.Parse(instructions[2]);
                        string subText = password.Substring(index, length);
                        int startIndex = password.IndexOf(subText);
                        password = password.Remove(startIndex, length);
                        Console.WriteLine(password);
                        break;

                    case "Substitute":
                        string substring = instructions[1];
                        string replacement = instructions[2];

                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, replacement);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
