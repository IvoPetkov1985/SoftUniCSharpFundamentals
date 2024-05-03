using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegsCount = int.Parse(Console.ReadLine());
            string biggest = string.Empty;
            double maxVolume = 0.0f;

            for (int i = 1; i <= kegsCount; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currentVolume = Math.PI * Math.Pow(radius, 2.0f) * height;

                if (currentVolume > maxVolume)
                {
                    maxVolume = currentVolume;
                    biggest = model;
                }
            }

            Console.WriteLine(biggest);
        }
    }
}
