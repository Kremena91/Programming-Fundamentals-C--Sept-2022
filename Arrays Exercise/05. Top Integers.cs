using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split().
                Select(int.Parse).
                ToArray();
            for (int i = 0; i < numbers.Length; i++) // обхождаме масива (1 4 3 2)
            {
                int currNum = numbers[i]; // вземаме числото от нулевия индекс (1), вземаме числото от първия индекс (4) и т.н.
                bool isTopInteger = true; // първоначално приемаме, че числото е topInteger и ще се опитваме да доказваме, че не е
                for (int j = i+1; j < numbers.Length; j++) // обхождаме всички числа отдясно на сегашното, започващ от сегашното число + 1
                {
                    int nextNum = numbers[j]; // следващ. число, на първа позиция (4), на втора позиция (3) и т.н.
                    if (nextNum >= currNum) // 4 >= 1 - да
                    {
                        isTopInteger = false; // ако открием следващо число, което е по-голямо от сегашното, казваме че не е topInteger
                        break; // прекъсваме търсенето на такъв topInteger (прекъсваме вътр. цикъл) 
                    }
                }
                if (isTopInteger == true)
                {
                    Console.Write(currNum + " ");
                }
            }
        }
    }
}
