using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalIncome = 0;

            string pattern = @"^\%(?<customer>[A-Z][a-z]+)\%[^\%\|\$\.]*?\<(?<product>\w+)\>[^\%\|\$\.]*?\|(?<count>\d+)\|[^\%\|\$\.]*?(?<price>\d+(\.\d+)?)\$[^\%\|\$\.]*?$";
            // [^\%\|\$\.]*? - между всяка група може да има всичко освен тези спец. символи; * - може да ги има, но може и да ги няма тези символи; ? - ако има такива символи вземи колкото се може по-малко, защото в противен случай ни взема число 0.3, а не 10.3
            // \w+ - може да има поне един word character
            
            Regex regex = new Regex(pattern);

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(inputLine);
                if (match.Success)
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double totalPrice = count * price;
                    totalIncome += totalPrice; // намираме общия доход

                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
