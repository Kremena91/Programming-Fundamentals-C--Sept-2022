using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            for (int i =0; i < n; i++)
            {
                for (int l = 0; l < n; l++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char firstChar = (char)('a'+i);
                        char secondChar = (char)('a' + l);
                        char ThirdChar = (char)('a' + k);
                        Console.WriteLine($"{firstChar}{secondChar}{ThirdChar}");
                    }
                }
            }
        }
    }
}
