using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes_2
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
                int serialNum = int.Parse(tokens[0]);
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);

                Item item = new Item();
                item.Name = itemName;
                item.Price = itemPrice;

                Box box = new Box();
                box.SerialNumber = serialNum;
                box.Item = item;
                box.ItemQuantity = itemQuantity;
                box.BoxPrice = itemQuantity * itemPrice;

                boxesList.Add(box);

                dataLine = Console.ReadLine();
            }

            foreach (Box currentBox in boxesList.OrderByDescending(x => x.BoxPrice))
            {
                Console.WriteLine(currentBox.SerialNumber);
                Console.WriteLine($"-- {currentBox.Item.Name} - ${currentBox.Item.Price:F2}: {currentBox.ItemQuantity}");
                Console.WriteLine($"-- ${currentBox.BoxPrice:F2}");
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    public class Box
    {
        public int SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal BoxPrice { get; set; }
    }
}
