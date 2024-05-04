using System;
using System.Linq;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int filler = int.Parse(Console.ReadLine());

            MatrixPrinter(filler);
        }

        static void MatrixPrinter(int n)
        {
            for (int rows = 1; rows <= n; rows++)
            {
                Console.WriteLine(String.Concat(Enumerable.Repeat(n.ToString() + " ", n)).Trim());
            }
            Console.WriteLine();
        }
    }
}
