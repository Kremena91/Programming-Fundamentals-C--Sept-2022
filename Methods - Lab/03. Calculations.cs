using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (type == "add")
            {
                getAdd(num1, num2);
            }
            else if (type == "multiply")
            {
                getMultiply(num1, num2);
            }
            else if (type == "substract")
            {
                getSubstract(num1, num2);
            }
            else if (type == "divide")
            {
                getDivide(num1, num2);
            }
        }

        static void getAdd(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        static void getMultiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }

        static void getSubstract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }

        static void getDivide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
