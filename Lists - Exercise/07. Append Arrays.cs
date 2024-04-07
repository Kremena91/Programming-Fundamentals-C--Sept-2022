using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                 .Split("|")
                 .ToList();

            items.Reverse();

            List<string> result = new List<string>();

            for (int i = 0; i < items.Count; i++)
            {
                List<string> numbers = items[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int j = 0; j < numbers.Count; j++)
                {
                    result.Add(numbers[j]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
