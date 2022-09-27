using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int spices = 26;
            int extracted = 0;
            int total = 0;
            int day = 0;
            if (startingYield < 100)
            {
                Console.WriteLine(day);
                Console.WriteLine(total);
            }
            else
            {
                while (startingYield >= 100)
                {
                    extracted = startingYield - spices;
                    total += extracted;
                    day += 1;
                    startingYield -= 10;
                }
                total -= spices;
                Console.WriteLine($"{day}");
                Console.WriteLine($"{total}");
            }
        }
    }
}           

