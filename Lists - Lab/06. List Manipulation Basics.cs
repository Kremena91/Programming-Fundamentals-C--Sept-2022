using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                // командата идва под формата на стринг масив , напр. Аdd 3
                string[] inputParams = input.Split();

                string command = inputParams[0]; // на нулева позиция е командата 

                if (command == "Add")
                {
                    int value = int.Parse(inputParams[1]); // на първа позиция е числото
                    numbers.Add(value);
                }
                else if (command == "Remove")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.Remove(value);
                }
                else if (command == "RemoveAt")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.RemoveAt(value);
                }
                else if (command == "Insert")
                {
                    int value = int.Parse(inputParams[1]); // числото
                    int index = int.Parse(inputParams[2]); // индекса

                    numbers.Insert(index, value);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
