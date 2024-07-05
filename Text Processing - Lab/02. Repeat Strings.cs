using System;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            string result = string.Empty; // което е същото като " "

            foreach (string currentWord in words)
            {
                for (int i = 0; i < currentWord.Length; i++) // трябва да принтираме думата колкото пъти е нейната дължина
                {
                    result += currentWord;
                }
            }
            Console.WriteLine(result);
        }
    }
}
