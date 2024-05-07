using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataLine = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (dataLine != "end")
            {
                string[] dataDetails = dataLine.Split(" ");

                string serialNum = dataDetails[0];
                string itemName = dataDetails[1];
                int itemQuantity = int.Parse(dataDetails[2]);
                decimal itemPrice = decimal.Parse(dataDetails[3]);

                Item item = new Item
                {
                    ItemName = itemName,
                    ItemPrice = itemPrice
                };

                Box box = new Box
                {
                    SerialNumber = serialNum,
                    ItemName = item,
                    ItemQuantity = itemQuantity,
                    PriceBox = item.ItemPrice * itemQuantity
                };

                boxes.Add(box);

                dataLine = Console.ReadLine();
            }

            foreach (var box in boxes.OrderByDescending(x => x.PriceBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.ItemName.ItemName} - ${box.ItemName.ItemPrice:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceBox:F2}");
            }
        }
    }

    class Box
    {
        public string SerialNumber { get; set; }

        public Item ItemName { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceBox { get; set; }


    }

    class Item
    {
        public string ItemName { get; set; }

        public decimal ItemPrice { get; set; }
    }
}
