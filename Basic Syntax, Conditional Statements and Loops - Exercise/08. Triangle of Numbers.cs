using System;

namespace _08._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) // колона
            {
                for (int l = 1; l <= i; l++) // ред
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
