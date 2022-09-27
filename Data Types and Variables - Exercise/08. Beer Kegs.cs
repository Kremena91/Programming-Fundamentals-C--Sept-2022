using System;
using System.Numerics;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal maxValue = decimal.MinValue;
            string maxValueModel = String.Empty;
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                decimal results = (decimal)Math.PI * radius * radius *height;
                if (results > maxValue)
                {
                    maxValue = results;
                    maxValueModel = model;
                }
            }
            Console.WriteLine($"{maxValueModel}");
        }
    }
}
