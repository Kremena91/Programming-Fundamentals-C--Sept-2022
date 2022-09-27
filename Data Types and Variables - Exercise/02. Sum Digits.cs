using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int copyNumber = n;
            int sum = 0;
            while (copyNumber > 0)
            {
                for (int i = 1; i <= copyNumber; i++)
                {
                    int lastNumber = copyNumber % 10;
                    copyNumber /= 10;
                    sum += lastNumber;
                }
            }  
                Console.WriteLine(sum);
        }
    }
}
