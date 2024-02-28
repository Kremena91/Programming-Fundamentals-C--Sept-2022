using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split().
                Select(int.Parse).
                ToArray();
            int count = 1; // Променливата counter се инициализира с 1, а не с 0, защото, към един вече съществуващ елемент се прибавят еднаквите му
            int max = 0; // max ще пази най-дългата поредица от повтарящи се елементи
            int element = 0; // element ще покаже кой точно елемент се повтаря
            for (int i = 0; i < numbers.Length-1; i++) 
            {
                    if (numbers[i] == numbers[i+1]) 
                    {
                        count++;
                    }
                    else
                    {
                    count = 1;// counter остава 1, с презумпцията, че има само 1 елемент сам по себе си
                }
                    if (count > max)
                    {
                    max = count;
                    element = numbers[i]; // тук пази първия елемент, който се повтаря, защото всеки път count се приравнява на 1, ако има само един подобен елемент
                    }
            }
            for (int j = 0; j < max; j++) // връща назад елементите, за да отпечата всички еднакви числа вляво
            {
                Console.Write($"{element} ");
            }
               
        }
    }
}
