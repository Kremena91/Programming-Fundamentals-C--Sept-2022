using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waterTank = 255;
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int quantities = int.Parse(Console.ReadLine());
                sum += quantities;
                if (sum > waterTank)
                {
                    Console.WriteLine($"Insufficient capacity!");
                    sum -= quantities;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
