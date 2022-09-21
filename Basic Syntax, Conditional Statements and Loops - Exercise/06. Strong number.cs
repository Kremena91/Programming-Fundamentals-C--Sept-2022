using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int copyN = n; // правим копие на числото
            int factorialSum = 0;
            while (copyN > 0)
            {
                int lastNumber = copyN % 10; // вземаме последната цифра
                copyN /= 10; // премахваме последната цифра
                int factorial = 1;
                for (int i = 1; i <= lastNumber; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;
            }
            if (factorialSum == n)
            {
                Console.WriteLine($"yes");
            }
            else
            {
                Console.WriteLine($"no");
            }
        }
    }
}
