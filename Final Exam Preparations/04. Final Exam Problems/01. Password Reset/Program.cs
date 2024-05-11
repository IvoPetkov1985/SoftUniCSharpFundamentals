using System;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string commandLine = Console.ReadLine();

            while (true)
            {
                if (commandLine == "Done")
                {
                    Console.WriteLine($"Your password is: {password}");
                    break;
                }

                string[] cmdArgs = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                switch (command)
                {
                    case "TakeOdd":
                        StringBuilder sequence = new StringBuilder();

                        for (int i = 0; i < password.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                sequence.Append(password[i]);
                            }
                        }

                        password = sequence.ToString();
                        break;

                    case "Cut":
                        int index = int.Parse(cmdArgs[1]);
                        int length = int.Parse(cmdArgs[2]);

                        string substring = password.Substring(index, length);
                        int firstIndex = password.IndexOf(substring);
                        password = password.Remove(firstIndex, length);
                        break;

                    case "Substitute":
                        string oldSubstring = cmdArgs[1];
                        string newSubstring = cmdArgs[2];

                        if (password.Contains(oldSubstring))
                        {
                            password = password.Replace(oldSubstring, newSubstring);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                            commandLine = Console.ReadLine();
                            continue;
                        }
                        break;
                }

                Console.WriteLine(password);
                commandLine = Console.ReadLine();
            }
        }
    }
}
