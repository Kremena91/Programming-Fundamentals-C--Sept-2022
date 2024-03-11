using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double priceCoffee = 1.50;
            double priceWater = 1.00;
            double priceCoke = 1.40;
            double priceSnakcs = 2.00;

            if (product == "coffee")
            {
                getTotalPriceOfCoffee(priceCoffee, quantity);
            }
            else if (product == "water")
            {
                getTotalPriceOfWater(priceWater, quantity);
            }
            else if (product == "coke")
            {
                getTotalPriceOfCoke(priceCoke, quantity);
            }
            else if (product == "snacks")
            {
                getTotalPriceOfSnacks(priceSnakcs, quantity);
            }
        }
        static void getTotalPriceOfCoffee(double priceCoffee, int quantity)
        {
            Console.WriteLine($"{(priceCoffee * quantity):f2}");
        }
        static void getTotalPriceOfWater(double priceWater, int quantity)
        {
            Console.WriteLine($"{(priceWater * quantity):f2}");
        }

        static void getTotalPriceOfCoke(double priceCoke, int quantity)
        {
            Console.WriteLine($"{(priceCoke * quantity):f2}");
        }

        static void getTotalPriceOfSnacks(double priceSnacks, int quantity)
        {
            Console.WriteLine($"{(priceSnacks * quantity):f2}");
        }
    }
}
