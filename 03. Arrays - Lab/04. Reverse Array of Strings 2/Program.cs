using System;

namespace _04._Reverse_Array_of_Strings_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOfStrings = Console.ReadLine().Split();

            for (int i = 0; i < arrOfStrings.Length / 2; i++)
            {
                string first = arrOfStrings[i];
                string second = arrOfStrings[arrOfStrings.Length - 1 - i];
                arrOfStrings[i] = second;
                arrOfStrings[arrOfStrings.Length - 1 - i] = first;
            }

            foreach (string element in arrOfStrings)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
