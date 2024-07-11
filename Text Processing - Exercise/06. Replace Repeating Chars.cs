using System;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            // Step 1 => text = aaaabbbccc => previousChar = text[0]
            char previousChar = text[0];   // 'a' вземаме първия символ и го печатаме
            Console.Write(previousChar);
            
            // Step 2 минaваме през целия текст като започваме от индекс 1
            for (int i = 1; i < text.Length; i++)
            {
                // Step 3 вземаме текущия символ и проверяваме дали е различен от предишния
                char currentChar = text[i];
                if (previousChar != currentChar) // ако предишния символ е различен от текущия символ а != b
                {
                    previousChar = currentChar; // вземаме следващия и го отпечатваме
                    Console.Write(previousChar); // 'ab'
                }
            }
        }
    }
}
