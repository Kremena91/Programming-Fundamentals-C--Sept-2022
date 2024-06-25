using System;


namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            //Welcome to SoftUni and have fun learning programming
            Random random = new Random();

            for (int i = 0; i < input.Length; i++) // минава през всички думи
            {
                int randomIndex = random.Next(0, input.Length); // случаен индекс от 0 до края на масива

                string currentWord = input[i]; // настоящата дума
                string nextWord = input[randomIndex]; // следващата дума

                // разместваме на случаен принцип
                input[i] = nextWord;
                input[randomIndex] = currentWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
