using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int currentNumber = i; // числото, което вземаме цифра по цифра за да сумираме и проверим сбора дали е 5, 7 или 11
                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber /= 10;    
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
