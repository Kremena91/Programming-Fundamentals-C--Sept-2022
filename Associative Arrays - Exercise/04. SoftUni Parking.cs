using System;
using System.Collections.Generic;

namespace _04.SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // key - username
            // value - licensePlateNumber
            Dictionary<string, string> register =
                new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //Освен Split() almost all other LINQ Functions require ToArray() after them
                //Например: Where(), Select(), OrderBy()... we write ToArray()
                string[] cmdArgs = Console.ReadLine()
                    .Split(' ');
                string cmdType = cmdArgs[0];
                string username = cmdArgs[1];

                if (cmdType == "register")
                {
                    string licensePlateNumber = cmdArgs[2]; // при тази команда четем един допълнителен ред

                    if (!register.ContainsKey(username)) // Ако този username няма регистрирана кола
                    {
                        register[username] = licensePlateNumber; // създай този потребител в речника и срещу него запази ст-та
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else // в противен случай
                    {
                        string registeredPlateNumber = register[username]; // вземи ст-та срещу този ключ (връща вече регистрирания номер)
                        Console.WriteLine($"ERROR: already registered with plate number {registeredPlateNumber}");
                    }
                }
                else if (cmdType == "unregister")
                {
                    if (!register.ContainsKey(username)) // ако несъществува този потребител
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else // ако съществува
                    {
                        register.Remove(username); // дерегистрираме го като го премахваме по ключ от речника 
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var kvp in register)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
