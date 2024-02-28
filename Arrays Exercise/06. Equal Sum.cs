using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split().
                Select(int.Parse).
                ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                if (i < 0 && i >= numbers.Length)
                {
                    Console.WriteLine($"0");
                    return;
                }
                    sumRight = 0;
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        sumRight += numbers[j];
                    }
                    sumLeft = 0;
                    for (int k = 0; k < i; k++)
                    {
                        sumLeft += numbers[k];
                    }
                    if (sumLeft == sumRight)
                    {
                        Console.WriteLine($"{i}");
                        return;
                    }
            }
            if (sumLeft > sumRight || sumLeft < sumRight)
            {
                Console.WriteLine($"no");
                
            }

        }
    }
}
