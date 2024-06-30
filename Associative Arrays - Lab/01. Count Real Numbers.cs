using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // key - стойността 
            // value - колко пъти се среща числото
            SortedDictionary<double, int> numberOcc
                = new SortedDictionary<double, int>();

            double[] inputNumbers = Console.ReadLine() // четем входните данни като масив
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (double currentNumber in inputNumbers)
            {
                if (!numberOcc.ContainsKey(currentNumber)) // Ако числото не съществува го добави
                {
                    numberOcc.Add(currentNumber, 0); // първоначално числото се среща 0 пъти
                }
                numberOcc[currentNumber] += 1; // увеличаваме с 1, когато срещнем същото число
            }

            foreach (var item in numberOcc)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
