using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            string people = Console.ReadLine();
            string[] peopleInfo = people.Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Person> peopleList = new List<Person>();

            for (int i = 0; i < peopleInfo.Length; i++)
            {
                string[] personInfo = peopleInfo[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string personName = personInfo[0];
                double personMoney = double.Parse(personInfo[1]);
                List<Product> productsList = new List<Product>();
                Person person = new Person(personName, personMoney, productsList);
                peopleList.Add(person);
            }

            string productsLine = Console.ReadLine();
            string[] productsArr = productsLine.Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Product> allProdusts = new List<Product>();

            for (int i = 0; i < productsArr.Length; i++)
            {
                string[] productInfo = productsArr[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string productName = productInfo[0];
                double productPrice = double.Parse(productInfo[1]);
                Product product = new Product(productName, productPrice);
                allProdusts.Add(product);
            }

            string purchaseLine = Console.ReadLine();

            while (purchaseLine != "END")
            {
                string[] purchaseTokens = purchaseLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = purchaseTokens[0];
                string product = purchaseTokens[1];

                Person person = peopleList.Find(x => x.Name == name);
                Product product1 = allProdusts.Find(x => x.Name == product);

                if (product1.Price > person.Money)
                {
                    Console.WriteLine($"{person.Name} can't afford {product1.Name}");
                }
                else
                {
                    person.Money -= product1.Price;

                    person.BagOfProducts.Add(product1);
                    Console.WriteLine($"{person.Name} bought {product1.Name}");
                }

                purchaseLine = Console.ReadLine();
            }

            List<Product> boughtProducts = new List<Product>();

            foreach (Person person1 in peopleList)
            {
                if (person1.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{person1.Name} - Nothing bought");
                }
                else
                {
                    List<string> personProductsNames = new List<string>();

                    foreach (Product product in person1.BagOfProducts)
                    {
                        personProductsNames.Add(product.Name);
                    }

                    Console.WriteLine($"{person1.Name} - {string.Join(", ", personProductsNames)}");
                }
            }
        }
    }

    public class Product
    {
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Person
    {
        public Person(string name, double money, List<Product> bagOfProducts)
        {
            this.Name = name;
            this.Money = money;
            this.BagOfProducts = bagOfProducts;
        }

        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> BagOfProducts { get; set; }
    }
}
