using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string barcode = Console.ReadLine();
                string barcodePattern = @"^\@\#+[A-Z][A-Za-z0-9]{4,}[A-Z]\@\#+$";

                Match match = Regex.Match(barcode, barcodePattern);

                if (match.Success)
                {
                    string digitPattern = @"\d";

                    StringBuilder productGroup = new StringBuilder();

                    MatchCollection digits = Regex.Matches(barcode, digitPattern);

                    foreach (Match digit in digits)
                    {
                        productGroup.Append(digit.Value);
                    }

                    if (productGroup.Length == 0)
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
