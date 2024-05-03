using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 1; i <= countOfOrders; i++)
            {
                decimal priceCapsule = decimal.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                decimal orderPrice = daysInMonth * capsulesCount * priceCapsule;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                totalPrice += orderPrice;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
