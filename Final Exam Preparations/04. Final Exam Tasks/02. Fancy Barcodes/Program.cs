using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int codesCount = int.Parse(Console.ReadLine());

            string pattern = @"\@\#+[A-Z][A-Za-z0-9]{4,}[A-Z]\@\#+";

            for (int i = 0; i < codesCount; i++)
            {
                string barcode = Console.ReadLine();

                Match validBarcode = Regex.Match(barcode, pattern);

                if (validBarcode.Success)
                {
                    string productGroup = string.Empty;

                    string digitPattern = @"\d";

                    MatchCollection digits = Regex.Matches(barcode, digitPattern);

                    foreach (Match digit in digits)
                    {
                        productGroup += digit.Value;
                    }

                    if (productGroup == "")
                    {
                        Console.WriteLine($"Product group: 00");
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
