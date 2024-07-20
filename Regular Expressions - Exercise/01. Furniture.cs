using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> furniture = new List<string>(); // запазва имената на мебелите
            double totalMoneySpend = 0;

            string pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
            // ^ и $ - така се обозначава начало и край на стринга; което показва, че искаме целия стринг да отговаря на нашия pattern и че имаме само един match
            //[A-Za-z]+ - името на мебелта да има поне една главна или малка буква 
            // \d+ - поне една цифра (цели числа)
            // (\.\d+)? - подгрупа за десетични числа // вместо ? може да бъде {0,1}; в къдравите скоби пишем колко пъти търсим дадено нещо, т.т. в случая от 0 до 1 път

            //Instance regex
            Regex regex = new Regex(pattern);

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(inputLine);
                
                if (match.Success) // Ако match-a е бил успешен
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    double pricePerUnit = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furniture.Add(furnitureName); // добавя към листа, щом се е мачнал успешно
                    totalMoneySpend += pricePerUnit * quantity;
                }
            }

            Console.WriteLine($"Bought furniture:");
            foreach (string furnitureName in furniture)
            {
                Console.WriteLine(furnitureName);
            }
            Console.WriteLine($"Total money spend: {totalMoneySpend:f2}");
        }
    }
}
