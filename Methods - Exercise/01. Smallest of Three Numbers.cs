using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
                    
            int minNum = GetMinNum(num1, num2, num3);
            Console.WriteLine(minNum);
        }

        static int GetMinNum(int num1, int num2, int num3)
        {
            int minNum = int.MaxValue;

            if (num1 <= num2 && num1 <= num3)
            {
                minNum = num1;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                minNum = num2;
            }
            else if (num3 <= num1 && num3 <= num2)
            {
                minNum = num3;
            }
            return minNum;
        }
    }
}

