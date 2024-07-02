using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // key - символ ch
            // value - колко пъти се среща
            Dictionary<char, int> occurances =
                new Dictionary<char, int>();

            string text = Console.ReadLine();
            foreach (char ch in text)
            {
                if (ch != ' ') // ako ch e различно от празно пространство
                {
                    // провери дали в речника се съдържа ключ, който отговаря на този ch
                    if (!occurances.ContainsKey(ch)) // ако не съществува
                    {
                        occurances[ch] = 0;
                    }

                    occurances[ch]++;
                }
            }

            foreach (var kvp in occurances)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
