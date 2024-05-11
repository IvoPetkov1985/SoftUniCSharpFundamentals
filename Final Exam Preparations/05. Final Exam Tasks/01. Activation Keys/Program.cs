using System;
using System.Text;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string commandLine = Console.ReadLine();

            while (commandLine != "Generate")
            {
                string[] tokens = commandLine.Split(">>>");
                string command = tokens[0];

                switch (command)
                {
                    case "Contains":
                        string substring = tokens[1];

                        if (activationKey.Contains(substring))
                        {
                            Console.WriteLine($"{activationKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;

                    case "Slice":
                        int start = int.Parse(tokens[1]);
                        int end = int.Parse(tokens[2]);

                        activationKey = activationKey.Remove(start, end - start);
                        Console.WriteLine(activationKey);
                        break;

                    default:
                        int startIndex = int.Parse(tokens[2]);
                        int endIndex = int.Parse(tokens[3]);

                        StringBuilder changedSubstring = new StringBuilder();

                        for (int i = startIndex; i < endIndex; i++)
                        {
                            char currentChar = activationKey[i];
                            if (char.IsLetter(currentChar))
                            {
                                if (tokens[1] == "Upper")
                                {
                                    string newLetter = currentChar.ToString().ToUpper();
                                    changedSubstring.Append(newLetter);
                                }
                                else
                                {
                                    string newLetter = currentChar.ToString().ToLower();
                                    changedSubstring.Append(newLetter);
                                }
                            }
                            else if (char.IsDigit(currentChar))
                            {
                                changedSubstring.Append(currentChar);
                            }
                        }

                        string newSubstringAsText = changedSubstring.ToString();
                        activationKey = activationKey.Remove(startIndex, newSubstringAsText.Length);
                        activationKey = activationKey.Insert(startIndex, newSubstringAsText);
                        Console.WriteLine(activationKey);
                        break;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
