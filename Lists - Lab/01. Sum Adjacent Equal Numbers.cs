using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count-1; i++) // не трябва да стигаме до последното число
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] = numbers[i] + numbers[i+1];
                    numbers.RemoveAt(i + 1); // къде точно ще премахнем елемент, след като сумираме, ел. на позиция i + 1 става излишно
                    i = -1; // за да се върнем отначало на for цикъла,така проверява пак отначало за еднакви числа и сумира
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
