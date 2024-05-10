using System;
using System.Text;

namespace _01._Decrypting_Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string commandLine = Console.ReadLine();

            while (commandLine != "Finish")
            {
                string[] cmdArgs = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = cmdArgs[0];

                if (currentCommand == "Replace")
                {
                    string oldValue = cmdArgs[1];
                    string newValue = cmdArgs[2];

                    if (message.Contains(oldValue))
                    {
                        message = message.Replace(oldValue, newValue);
                        Console.WriteLine(message);
                    }
                }
                else if (currentCommand == "Cut")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    if (startIndex >= 0 && startIndex < message.Length
                        && endIndex >= 0 && endIndex < message.Length)
                    {
                        message = message.Remove(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
                else if (currentCommand == "Make")
                {
                    StringBuilder stringBuilder = new StringBuilder();

                    foreach (char symbol in message)
                    {
                        if (cmdArgs[1] == "Upper")
                        {
                            stringBuilder.Append(symbol.ToString().ToUpper());
                        }
                        else
                        {
                            stringBuilder.Append(symbol.ToString().ToLower());
                        }
                    }

                    message = stringBuilder.ToString();
                    Console.WriteLine(message);
                }
                else if (currentCommand == "Check")
                {
                    string substring = cmdArgs[1];

                    if (message.Contains(substring))
                    {
                        Console.WriteLine($"Message contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {substring}");
                    }
                }
                else if (currentCommand == "Sum")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    if (startIndex >= 0 && startIndex < message.Length
                        && endIndex >= 0 && endIndex < message.Length)
                    {
                        int sum = 0;

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            char current = message[i];
                            sum += current;
                        }

                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }

                commandLine = Console.ReadLine();
            }
        }
    }
}
