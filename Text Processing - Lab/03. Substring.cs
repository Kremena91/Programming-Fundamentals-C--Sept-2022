using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string specialWord = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(specialWord)) // докато нашия текст съдържа специалната дума, която трябва да премахваме от текста
            {
                int startIndex = text.IndexOf(specialWord); // искаме от целия текст да намерим на кой индекс стартира специална дума
                text = text.Remove(startIndex, specialWord.Length);
                // премахни думата като използваш метода removе ( от кой индекс стартира думата и колко е дълга думата)
                // след това презапиши text наново и се върни в while цикъла да търсиш дали след като си изтрил тази дума все още се съдържа някоя, която отговаря на спец. думи
            }
            Console.WriteLine(text);
        }
    }
}
