using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            int startIndex = (int)start;
            int endIndex = (int)end;

            PrintTheCharsInRange(start, end);
            
        }
        static void PrintTheCharsInRange(int startIndex, int endIndex)
        {
            char currCh;
            if (startIndex > endIndex)
            {
                for (int i = endIndex + 1; i < startIndex; i++)
                {
                    currCh = (char)i;
                    Console.Write($"{currCh} ");
                }
            }
            for (int i = startIndex + 1; i < endIndex; i++)
            {
                currCh = (char)i;
                Console.Write($"{currCh} ");
            }
        }
    }
}
