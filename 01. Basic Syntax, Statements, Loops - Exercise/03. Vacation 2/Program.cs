using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            decimal singlePersonPrice = 0.0m;

            switch (groupType)
            {
                case "Students":
                    if (dayOfWeek == "Friday")
                    {
                        singlePersonPrice = 8.45m;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        singlePersonPrice = 9.80m;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        singlePersonPrice = 10.46m;
                    }

                    if (countOfPeople >= 30)
                    {
                        singlePersonPrice *= 0.85m;
                    }
                    break;

                case "Business":
                    if (dayOfWeek == "Friday")
                    {
                        singlePersonPrice = 10.90m;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        singlePersonPrice = 15.60m;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        singlePersonPrice = 16.00m;
                    }

                    if (countOfPeople >= 100)
                    {
                        countOfPeople -= 10;
                    }
                    break;

                case "Regular":
                    if (dayOfWeek == "Friday")
                    {
                        singlePersonPrice = 15.00m;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        singlePersonPrice = 20.00m;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        singlePersonPrice = 22.50m;
                    }

                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        singlePersonPrice *= 0.95m;
                    }
                    break;
            }

            decimal totalPrice = singlePersonPrice * countOfPeople;

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
