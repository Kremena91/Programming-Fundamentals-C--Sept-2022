using System;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int countPeople = int.Parse(Console.ReadLine());
                array[i] = countPeople;
                sum += countPeople;
            }
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine($"{sum}");
        }
    }
}
