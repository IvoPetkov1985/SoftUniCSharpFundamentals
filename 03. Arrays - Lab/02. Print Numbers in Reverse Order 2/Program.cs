using System;

namespace _02._Print_Numbers_in_Reverse_Order_2
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
                int first = numbers[i];
                int last = numbers[numbers.Length - 1 - i];
                numbers[i] = last;
                numbers[numbers.Length - 1 - i] = first;
            }

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
