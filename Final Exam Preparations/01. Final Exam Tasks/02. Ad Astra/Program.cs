using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            string pattern = @"(\#|\|)(?<name>[A-Za-z\s]+)\1(?<date>\d{2}/\d{2}/\d{2})\1(?<calories>\d+)\1";

            MatchCollection foods = Regex.Matches(inputLine, pattern);
            int totalCalories = 0;
            List<Food> foodsCollection = new List<Food>();

            foreach (Match match in foods)
            {
                if (match.Success)
                {
                    string foodName = match.Groups["name"].Value;
                    string term = match.Groups["date"].Value;
                    int calories = int.Parse(match.Groups["calories"].Value);

                    Food food = new Food(foodName, term, calories);
                    foodsCollection.Add(food);

                    totalCalories += calories;
                }
            }

            Console.WriteLine($"You have food to last you for: {totalCalories / 2000} days!");

            foreach (Food item in foodsCollection)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Food
    {
        public Food(string name, string date, int calories)
        {
            this.Name = name;
            this.BestBefore = date;
            this.Calories = calories;
        }
        public string Name { get; set; }
        public string BestBefore { get; set; }
        public int Calories { get; set; }
        public override string ToString()
        {
            return $"Item: {Name}, Best before: {BestBefore}, Nutrition: {Calories}";
        }
    }
}
