using System;


namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int product = 0;
            if (number2 > 10)
            {
                product = number * number2;
                Console.WriteLine($"{number} X {number2} = {product}");
            }
            for (int i = number2; i <= 10; i++)
            {
                product = number * i;
                Console.WriteLine($"{number} X {i} = {product}");
            }
        }
    }
}

