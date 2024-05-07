using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataLine = Console.ReadLine();
            List<Box> boxesList = new List<Box>();

            while (dataLine != "end")
            {
                string[] tokens = dataLine.Split(" ");
                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity, itemPrice);

                boxesList.Add(box);

                dataLine = Console.ReadLine();
            }

            List<Box> orderedList = boxesList.OrderByDescending(x => x.BoxPrice).ToList();

            foreach (Box current in orderedList)
            {
                Console.WriteLine($"{current.SerialNumber}");
                Console.WriteLine($"-- {current.Item.Name} - ${current.Item.Price:F2}: {current.ItemQuantity}");
                Console.WriteLine($"-- ${current.BoxPrice:F2}");
            }
        }
    }

    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity, decimal itemPrice)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
            BoxPrice = itemPrice * itemQuantity;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal BoxPrice { get; set; }
    }
}
