using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split();

                if (cmdArgs[0] == "Add")
                {
                    int numberToAdd = int.Parse(cmdArgs[1]);
                    wagons.Add(numberToAdd);
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int passengers = int.Parse(cmdArgs[0]);
                        if ((wagons[i] + passengers) <= maxCapacity)
                        {
                        wagons[i] += passengers;
                        break;
                    }  
                }
            }
                
         }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
