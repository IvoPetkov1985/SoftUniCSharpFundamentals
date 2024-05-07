using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();

            string[] allPeople = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < allPeople.Length; i++)
            {
                string[] personInfo = allPeople[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                decimal money = decimal.Parse(personInfo[1]);
                List<string> boughtProducts = new List<string>();
                Person person = new Person(name, money, boughtProducts);
                peopleList.Add(person);
            }

            string[] allProducts = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Product> productsList = new List<Product>();

            for (int i = 0; i < allProducts.Length; i++)
            {
                string[] productInfo = allProducts[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string productName = productInfo[0];
                decimal productPrice = decimal.Parse(productInfo[1]);
                Product product = new Product(productName, productPrice);
                productsList.Add(product);
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "END")
            {
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string clientName = tokens[0];
                string productName = tokens[1];

                Person currentClient = peopleList.Find(x => x.Name == clientName);
                Product currentProduct = productsList.Find(x => x.ProductName == productName);

                if (currentProduct.Price > currentClient.Money)
                {
                    Console.WriteLine($"{currentClient.Name} can't afford {currentProduct.ProductName}");
                }
                else
                {
                    currentClient.Money -= currentProduct.Price;
                    currentClient.BagOfProducts.Add(currentProduct.ProductName);
                    Console.WriteLine($"{currentClient.Name} bought {currentProduct.ProductName}");
                }

                commandLine = Console.ReadLine();
            }

            foreach (Person client in peopleList)
            {
                if (client.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{client.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{client.Name} - {string.Join(", ", client.BagOfProducts)}");
                }
            }
        }
    }

    public class Product
    {
        public Product(string name, decimal price)
        {
            this.ProductName = name;
            this.Price = price;
        }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }

    public class Person
    {
        public Person(string name, decimal money, List<string> bagOfProducts)
        {
            Name = name;
            Money = money;
            BagOfProducts = bagOfProducts;
        }

        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<string> BagOfProducts { get; set; }
    }
}
