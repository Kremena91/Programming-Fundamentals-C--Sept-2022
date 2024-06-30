using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ["string", new List<string> {"str1", "str2"}], т.е. към една дума може да имаме няколко синонима
            Dictionary<string, List<string>> synonyms
                = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonyms.ContainsKey(word)) // Ако думата не се сърдържа в нашия речник 
                {
                    List<string> newListForCurrentWord = new List<string>(); // създаваме нов лист за тази дума
                    synonyms.Add(word, newListForCurrentWord); // искаме да добавиш тази дума 
                }
                synonyms[word].Add(synonym); // искаме в нашия речник на дадената дума да добавим синонима, който сме открили 
            }

            foreach (var item in synonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}

