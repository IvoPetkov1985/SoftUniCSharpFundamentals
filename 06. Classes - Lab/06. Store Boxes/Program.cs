using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            List<Box> boxesList = new List<Box>();

            while (inputData != "end")
            {
                string[] tokens = inputData.Split(" ");
                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);

                Item item = new Item(itemName, itemPrice);

                decimal boxPrice = item.ItemPrice * itemQuantity;

                Box box = new Box(serialNumber, item, itemQuantity, boxPrice);
                boxesList.Add(box);

                inputData = Console.ReadLine();
            }

            foreach (Box box in boxesList.OrderByDescending(b => b.BoxPrice))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.ItemName} - ${box.Item.ItemPrice:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:F2}");
            }
        }
    }

    public class Item
    {
        public Item(string name, decimal price)
        {
            ItemName = name;
            ItemPrice = price;
        }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
    }

    public class Box
    {
        public Box(string serial, Item item, int quantity, decimal boxPrice)
        {
            SerialNumber = serial;
            Item = item;
            ItemQuantity = quantity;
            BoxPrice = boxPrice;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal BoxPrice { get; set; }
    }
}
