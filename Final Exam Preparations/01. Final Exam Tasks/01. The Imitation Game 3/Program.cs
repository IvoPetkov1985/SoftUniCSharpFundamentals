using System;
using System.Linq;

namespace _01._The_Imitation_Game_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            string instructionsLine = Console.ReadLine();

            while (instructionsLine != "Decode")
            {
                string[] tokens = instructionsLine.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens.First();

                if (command == "Move")
                {
                    int numberOfLetters = int.Parse(tokens.Last());
                    string sequenceToMove = encryptedMessage.Substring(0, numberOfLetters);

                    encryptedMessage = encryptedMessage.Remove(0, numberOfLetters);
                    encryptedMessage = encryptedMessage.Insert(encryptedMessage.Length, sequenceToMove);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[1]);
                    string value = tokens.Last();

                    encryptedMessage = encryptedMessage.Insert(index, value);
                }
                else if (command == "ChangeAll")
                {
                    string sequenceToChange = tokens[1];
                    string replacement = tokens.Last();

                    if (encryptedMessage.Contains(sequenceToChange))
                    {
                        encryptedMessage = encryptedMessage.Replace(sequenceToChange, replacement);
                    }
                }

                instructionsLine = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
