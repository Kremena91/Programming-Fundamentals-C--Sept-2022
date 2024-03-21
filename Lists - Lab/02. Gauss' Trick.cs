using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>(); // създаваме нов лист в който да пазим резултата

            for (int i = 0; i < numbers.Count/2; i++)
            {
                int currentSum = numbers[i] + numbers[numbers.Count - 1 - i]; // събираме първото с посл. число
                result.Add(currentSum); // добавяме сумата
            }

            if (numbers.Count % 2 != 0) // ако е нечетно
            {
                result.Add(numbers[numbers.Count/2]); // добавяме числото от колекцията елементи
            }
            
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
