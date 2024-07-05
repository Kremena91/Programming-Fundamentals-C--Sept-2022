using System;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ");
            string text = Console.ReadLine();

            foreach (string currentBannedWord in bannedWords)
            {
                // Console.WriteLine(new string('*', 10)); - задаваме символа и колко на брой пъти искаме да се принтира този символ
                text = text.Replace(currentBannedWord, new string('*', currentBannedWord.Length));
                // презаписваме в нов текст и задаваме думата за премахване, нов стринг със символа и дължината на думата за премахване
            }
            Console.WriteLine(text);
        }
    }
}
