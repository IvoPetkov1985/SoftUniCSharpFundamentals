using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsCount = int.Parse(Console.ReadLine());

            int[] numbers = new int[numsCount];

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                numbers[i] = currentNum;
            }

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int buff = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = buff;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
