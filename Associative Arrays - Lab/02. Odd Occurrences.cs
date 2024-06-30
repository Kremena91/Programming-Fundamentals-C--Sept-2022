using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Иска се от нас като изход да извадим всяка част от входящия стринг (без спейсовете), която се среща нечетен брой пъти в него. В дадения пример C# и PHP се срещат по 3 пъти, а 1 и 5 - по въднъж. Java и 3 се срещат по 2 пъти и затова не са изведени на изхода
            
            string[] words = Console.ReadLine().ToLower().Split();

            // key - думата
            // value - колко пъти се среща думата
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordInLowerCase = word.ToLower(); // прави думата с малки букви

                if(counts.ContainsKey(wordInLowerCase)) // Ако думата се съдържа в речника, броим колко пъти се среща
                {
                    counts[wordInLowerCase]++;
                }
                else // в противен случай я добавяме
                {
                    counts.Add(wordInLowerCase, 1);
                } 
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 == 1) // ако думата се среща нечетен брой пъти
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
