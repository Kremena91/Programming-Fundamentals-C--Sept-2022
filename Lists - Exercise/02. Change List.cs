using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split();
                string cmdType = cmdArgs[0];

                if (cmdType == "Delete")
                {
                    int numberToDelete = int.Parse(cmdArgs[1]);
                    numbers.RemoveAll(x => x == numberToDelete);
                }
                else if (cmdType == "Insert")
                {
                    int number = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    numbers.Insert(index, number);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
