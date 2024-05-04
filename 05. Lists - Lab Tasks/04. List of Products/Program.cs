using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfProducts = int.Parse(Console.ReadLine());

            List<string> listProducts = new List<string>();

            for (int i = 0; i < countOfProducts; i++)
            {
                string currentProduct = Console.ReadLine();
                listProducts.Add(currentProduct);
            }

            listProducts.Sort();

            for (int i = 0; i < listProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{listProducts[i]}");
            }
        }
    }
}
