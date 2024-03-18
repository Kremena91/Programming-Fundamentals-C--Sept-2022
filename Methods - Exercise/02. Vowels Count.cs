using System;
using System.Linq;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int vowelsCount = GetVowelsCount(text);
            Console.WriteLine(vowelsCount);

            static int GetVowelsCount (string text)
            {
                int vowelsCount = 0;
                char[] vowels = new char[] {'a', 'e', 'o', 'u', 'i', 'y'}; // представяме гласните като масив от символи
                foreach (char letter in text.ToLower()) // с foreach можем да минем през всеки един елемент на масива
                {                                       // ToLower взема текста и го прави с малки букви
                    if (vowels.Contains(letter)) // ако масива с гласни съдържа сегашната буква, броим, че има 1 гласна
                    {
                        vowelsCount++;
                    }
                }
                return vowelsCount;
            }
        }
    }
}
