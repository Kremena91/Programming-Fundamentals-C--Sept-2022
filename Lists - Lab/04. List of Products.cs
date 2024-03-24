using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List <string> products = new List<string>(); // създаваме лист за продуктите

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);  // добавяме в листа всеки продукт
            }
            products.Sort(); // подреждаме по възходящ ред

            for (int i = 0; i < products.Count; i++) 
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
