using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            if (operation == "+")
            {
                int result = getAdd(firstNum, secondNum);
                Console.WriteLine(result);
            }
            else if (operation == "*")
            {
                int result = getMultiply(firstNum, secondNum);
                Console.WriteLine(result);
            }
            else if (operation == "-")
            {
                int result = getSubstract(firstNum, secondNum);
                Console.WriteLine(result);
            }
            else if (operation == "/")
            {
                int result = getDivide(firstNum, secondNum);
                Console.WriteLine(result);
            }
        }
        static int getAdd(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            return result;
        }

        static int getMultiply(int firstNum, int secondNum)
        {
            int result = firstNum * secondNum;
            return result;
        }

        static int getSubstract(int firstNum, int secondNum)
        {
            int result = firstNum - secondNum;
            return result;
        }

        static int getDivide(int firstNum, int secondNum)
        {
            int result = firstNum / secondNum;
            return result;
        }
    }
}
