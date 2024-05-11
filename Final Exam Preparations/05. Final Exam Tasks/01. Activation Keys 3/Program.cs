using System;
using System.Linq;
using System.Text;

namespace _01._Activation_Keys_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string commandLine = Console.ReadLine();

            while (commandLine != "Generate")
            {
                string[] cmdArgs = commandLine
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string currentCommand = cmdArgs.First();

                if (currentCommand == "Contains")
                {
                    string substring = cmdArgs.Last();

                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (currentCommand == "Slice")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs.Last());

                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }
                else
                {
                    int start = int.Parse(cmdArgs[2]);
                    int end = int.Parse(cmdArgs.Last());

                    StringBuilder stringBuilder = new StringBuilder();

                    for (int i = start; i < end; i++)
                    {
                        if (cmdArgs[1] == "Lower")
                        {
                            stringBuilder.Append(activationKey[i].ToString().ToLower());
                        }
                        else
                        {
                            stringBuilder.Append(activationKey[i].ToString().ToUpper());
                        }
                    }

                    string oldValue = activationKey.Substring(start, end - start);
                    string newValue = stringBuilder.ToString();

                    activationKey = activationKey.Replace(oldValue, newValue);
                    Console.WriteLine(activationKey);
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
