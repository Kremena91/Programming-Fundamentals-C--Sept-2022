using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            long factoriel1 = GetFactorielFirstNumber(n1);
            long factoriel2 = GetFactorielSecondNumber(n2);

            double result = (double)factoriel1 / factoriel2;
            Console.WriteLine($"{result:F2}");
        }

        static long GetFactorielFirstNumber(int n1)
        {
            long factorial1 = 1;
            for (int i = 1; i <= n1; i++)
            {
                factorial1 *= i;
            }
            return factorial1;
        }

        static long GetFactorielSecondNumber(int n2)
        {
            long factorial2 = 1;
            for (int j = 1; j <= n2; j++)
            {
                factorial2 *= j;
            }
            return factorial2;
        }
    }
}




