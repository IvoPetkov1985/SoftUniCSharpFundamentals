using System;
using System.Linq;
using System.Text;

namespace _01._Password_Reset_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string predefined = Console.ReadLine();

            string commandLine = Console.ReadLine();

            while (commandLine != "Done")
            {
                string[] cmdArgs = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs.First();

                switch (command)
                {
                    case "TakeOdd":
                        StringBuilder oddPositions = new StringBuilder();

                        for (int i = 0; i < predefined.Length; i++)
                        {
                            if (i % 2 == 1)
                            {
                                oddPositions.Append(predefined[i]);
                            }
                        }

                        predefined = oddPositions.ToString();
                        break;

                    case "Cut":
                        int startIndex = int.Parse(cmdArgs[1]);
                        int length = int.Parse(cmdArgs.Last());
                        string substring = predefined.Substring(startIndex, length);
                        int firstIndex = predefined.IndexOf(substring);
                        predefined = predefined.Remove(firstIndex, length);
                        break;

                    case "Substitute":
                        string oldValue = cmdArgs[1];
                        string newValue = cmdArgs.Last();

                        if (predefined.Contains(oldValue))
                        {
                            predefined = predefined.Replace(oldValue, newValue);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                            commandLine = Console.ReadLine();
                            continue;
                        }
                        break;
                }

                Console.WriteLine(predefined);
                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {predefined}");
        }
    }
}
