using System;

namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int product = 0;
            for (int i = 1; i <= 10; i++)
            {
                product = number * i;
                Console.WriteLine($"{number} X {i} = {product}");
            }
        }
    }
}
