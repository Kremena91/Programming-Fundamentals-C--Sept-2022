using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyList = new Dictionary<string, List<string>>();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] splitComand = command.Split("->").ToArray();
                string companyName = splitComand[0];
                string employeeID = splitComand[1];

                if (!companyList.ContainsKey(companyName))
                {
                    companyList.Add(companyName, new List<string>());
                }
                if (!companyList[companyName].Contains(employeeID))
                {
                    companyList[companyName].Add(employeeID);
                }
            }
            foreach (var kvp in companyList)
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var emploeeID in kvp.Value)
                {
                    Console.WriteLine($"--{emploeeID}");
                }
            }
        }
    }
}
