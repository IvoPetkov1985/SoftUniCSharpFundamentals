using System;
using System.Text;
using System.Linq;

namespace _01._Activation_Keys_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string instructionLine = Console.ReadLine();

            while (instructionLine != "Generate")
            {
                string[] cmdArgs = instructionLine.Split(">>>");
                string currentCommand = cmdArgs.First();

                switch (currentCommand)
                {
                    case "Contains":
                        string subText = cmdArgs.Last();

                        if (activationKey.Contains(subText))
                        {
                            Console.WriteLine($"{activationKey} contains {subText}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;

                    case "Flip":
                        int startIndex = int.Parse(cmdArgs[2]);
                        int endIndex = int.Parse(cmdArgs.Last());

                        StringBuilder newSubstring = new StringBuilder();

                        for (int i = startIndex; i < endIndex; i++)
                        {
                            if (cmdArgs[1] == "Upper")
                            {
                                newSubstring.Append(activationKey[i].ToString().ToUpper());
                            }
                            else
                            {
                                newSubstring.Append(activationKey[i].ToString().ToLower());
                            }
                        }

                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        activationKey = activationKey.Insert(startIndex, newSubstring.ToString());
                        Console.WriteLine(activationKey);
                        break;

                    case "Slice":
                        int start = int.Parse(cmdArgs[1]);
                        int end = int.Parse(cmdArgs.Last());

                        activationKey = activationKey.Remove(start, end - start);
                        Console.WriteLine(activationKey);
                        break;
                }

                instructionLine = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
