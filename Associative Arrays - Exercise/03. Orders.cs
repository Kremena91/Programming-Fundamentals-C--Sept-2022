using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> product = new Dictionary<string, List<double>>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] cmdArgs = input.Split();
                string name = cmdArgs[0];
                double price = double.Parse(cmdArgs[1]);
                double quantity = double.Parse(cmdArgs[2]);

                if (!product.ContainsKey(name))
                {
                    List<double> addToList = new List<double>() {price, quantity};
                    product.Add(name, addToList);
                }
                else
                {
                    List<double> currentList = product[name];

                    currentList[0] = price;
                    currentList[1] += quantity;
                    product[name] = currentList;
                }

                input = Console.ReadLine();
            }

            foreach (var item in product)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
            }

        }
    }
}
