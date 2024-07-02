using System;
using System.Collections.Generic;

namespace _02_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // key - името на ресурса
            // value - количеството
            Dictionary<string, int> resources =
                new Dictionary<string, int>();

            string resource;
            while ((resource = Console.ReadLine()) != "stop") // на четните редове получаваме ресурс
            {
                int quantity = int.Parse(Console.ReadLine()); // на нечетните редове количество

                if (!resources.ContainsKey(resource)) //ако не съществува ключ за този ресурс
                {
                    resources[resource] = 0; // като първоначалната стойност задаваме 0, т.е. първоначално кличеството на този ресурс е 0
                }
                resources[resource] += quantity; // всеки път независимо дали съществува или не, към ресурсите на този ресурс ще прибавяме количеството

                // Втори начин
                //if (!resource.Contains(resource)) // Ако не съществува този ресурс
                //{
                //    resources[resource] = quantity; // в ресурсите срещу негово име добавяме количеството
                //}
                //else
                //{
                //    resources[resource] += quantity; // ако вече съществува срещу неговото име прибавяме количеството
                //}
            }

            foreach (var rqp in resources) // за всяка двойка в ресурсите принтираме ресурс и количество
            {
                Console.WriteLine($"{rqp.Key} -> {rqp.Value}");
            }
        }
    }
}
