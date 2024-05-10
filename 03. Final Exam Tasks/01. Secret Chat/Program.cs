using System;
using System.Text;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string instructionsLine = Console.ReadLine();

            while (instructionsLine != "Reveal")
            {
                string[] tokens = instructionsLine.Split(":|:");
                string instruction = tokens[0];

                switch (instruction)
                {
                    case "InsertSpace":
                        int index = int.Parse(tokens[1]);
                        message = message.Insert(index, " ");
                        Console.WriteLine(message);
                        break;

                    case "Reverse":
                        string textToReverse = tokens[1];

                        if (message.Contains(textToReverse))
                        {
                            int firstIndex = message.IndexOf(textToReverse);
                            message = message.Remove(firstIndex, textToReverse.Length);

                            StringBuilder newSubstring = new StringBuilder();
                            for (int i = 0; i < textToReverse.Length; i++)
                            {
                                newSubstring.Append(textToReverse[textToReverse.Length - 1 - i].ToString());
                            }

                            string newFragment = newSubstring.ToString();
                            message = message.Insert(message.Length, newFragment);
                            Console.WriteLine(message);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    case "ChangeAll":
                        string oldSequence = tokens[1];
                        string newSequence = tokens[2];

                        message = message.Replace(oldSequence, newSequence);
                        Console.WriteLine(message);
                        break;
                }

                instructionsLine = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
