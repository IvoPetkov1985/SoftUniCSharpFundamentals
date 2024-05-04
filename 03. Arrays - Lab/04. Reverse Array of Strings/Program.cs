using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = Console.ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i < strArray.Length / 2; i++)
            {
                string buff = strArray[i];
                strArray[i] = strArray[strArray.Length - 1 - i];
                strArray[strArray.Length - 1 - i] = buff;
            }

            Console.WriteLine(string.Join(" ", strArray));
        }
    }
}
