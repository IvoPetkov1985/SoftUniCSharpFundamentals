using System;
using System.Text;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string commandLine = Console.ReadLine();

            while (true)
            {
                if (commandLine == "Reveal")
                {
                    break;
                }

                string[] cmdArgs = commandLine.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(cmdArgs[1]);
                    message = message.Insert(index, " ");
                }
                else if (command == "Reverse")
                {
                    string substring = cmdArgs[1];

                    if (message.Contains(substring))
                    {
                        string reversed = new string(substring.Reverse().ToArray());
                        int startIndex = message.IndexOf(substring);
                        message = message.Remove(startIndex, substring.Length);
                        message = message += reversed;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        commandLine = Console.ReadLine();
                        continue;
                    }
                }
                else if (command == "ChangeAll")
                {
                    string oldSubstring = cmdArgs[1];
                    string newSubstring = cmdArgs[2];

                    message = message.Replace(oldSubstring, newSubstring);
                }

                Console.WriteLine(message);
                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
