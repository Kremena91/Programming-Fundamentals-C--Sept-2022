using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = GetSumNum1AddToNum2(num1, num2);
            int substract = GetSumSubstractNum3(sum, num3);
            Console.WriteLine(substract);
            
        }

        static int GetSumNum1AddToNum2(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        static int GetSumSubstractNum3(int sum, int num3)
        {
            int substract = sum - num3;
            return substract;
        }
    }
}
