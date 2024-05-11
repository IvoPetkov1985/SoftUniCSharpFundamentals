using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            string decrypted = Console.ReadLine();

            while (decrypted != "end")
            {
                StringBuilder encrypted = new StringBuilder();

                foreach (char symbol in decrypted)
                {
                    char charToAppend = (char)(symbol - key);
                    encrypted.Append(charToAppend);
                }

                string input = encrypted.ToString();

                string pattern = @"\@(?<name>[A-Za-z]+)[^\@\-\!\:\>]*?\!(?<behaviour>[GN])\!";

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string behaviour = match.Groups["behaviour"].Value;

                    if (behaviour == "G")
                    {
                        Console.WriteLine(name);
                    }
                }

                decrypted = Console.ReadLine();
            }
        }
    }
}
