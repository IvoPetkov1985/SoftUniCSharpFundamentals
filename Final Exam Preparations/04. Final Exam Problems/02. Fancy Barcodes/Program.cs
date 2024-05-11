using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int barcodeCount = int.Parse(Console.ReadLine());

            string barcodePattern = @"^\@\#+(?<code>[A-Z][A-Za-z0-9]{4,}[A-Z])\@\#+$";

            for (int i = 0; i < barcodeCount; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, barcodePattern);

                if (match.Success)
                {
                    string barcode = match.Groups["code"].Value;
                    string productGroup = string.Empty;

                    foreach (char symbol in barcode)
                    {
                        if (char.IsDigit(symbol))
                        {
                            productGroup += symbol.ToString();
                        }
                    }

                    if (productGroup == string.Empty)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {productGroup}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
