using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\||\#)(?<item>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";

            MatchCollection matches = Regex.Matches(input, pattern);
            int totalCalories = 0;
            List<Food> foods = new List<Food>();

            foreach (Match item in matches)
            {
                if (item.Success)
                {
                    string itemName = item.Groups["item"].Value;
                    string bestBefore = item.Groups["date"].Value;
                    int calories = int.Parse(item.Groups["calories"].Value);
                    totalCalories += calories;

                    Food currentItem = new Food();
                    currentItem.ItemName = itemName;
                    currentItem.BestBefore = bestBefore;
                    currentItem.Calories = calories;

                    foods.Add(currentItem);
                }
            }

            int days = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Food product in foods)
            {
                Console.WriteLine($"Item: {product.ItemName}, Best before: {product.BestBefore}, Nutrition: {product.Calories}");
            }
        }
    }

    public class Food
    {
        public string ItemName { get; set; }
        public string BestBefore { get; set; }
        public int Calories { get; set; }
    }
}
