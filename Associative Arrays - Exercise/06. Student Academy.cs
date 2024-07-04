using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> student = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!student.ContainsKey(name))
                {
                    student.Add(name, new List<double>());
                }
                    student[name].Add(grade);
            }

            foreach (var kvp in student
                .Where(x => x.Value.Average(x => x) >= 4.50))
            {
                Console.WriteLine($"{kvp.Key} -> {(kvp.Value.Average(x => x)):f2}");
            }
        }
    }
}

