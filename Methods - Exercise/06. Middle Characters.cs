using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();
            int length = symbol.Length;

            string result = GetMiddleCharacter(symbol);
            Console.WriteLine(result);
        }

        static string GetMiddleCharacter(string symbol)
        {
            string result= " ";
            
            if (symbol.Length % 2 == 0)
            {
                result = symbol[symbol.Length / 2 - 1].ToString() + symbol[symbol.Length / 2].ToString();
            }
            else if (symbol.Length % 2 != 0)
            {
                result = symbol[symbol.Length / 2].ToString();
            }
            return result;
        }
        
            
    }
}
