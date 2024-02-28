using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split().
                Select(int.Parse).
                ToArray();
            int givenNumb = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                sum = 0;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextNum = numbers[j];
                    sum = numbers[i] + numbers[j];
                    if (sum == givenNumb)
                    {
                        Console.WriteLine($"{currNum} {nextNum}");
                    }
                }
            }
        }
    }
}
