using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // -12345
            int absValue = Math.Abs(int.Parse(input)); // 12345
            
            int sumOddOfDigits = GetSumOddOfDigits(absValue);
            int sumEvenOfDigits = GetSumEvenOfDigits(absValue);

            int result = sumEvenOfDigits * sumOddOfDigits;
            Console.WriteLine(result);
        }
        static int GetSumEvenOfDigits(int absValue)
        {
            int copyAbsValue = absValue;
            int sum = 0;
            while (copyAbsValue > 0)
            {
                int lastNumber = copyAbsValue % 10;
                copyAbsValue /= 10;
                if (lastNumber % 2 == 0)
                {
                    sum += lastNumber;
                }
            }
            return sum;
        }
        static int GetSumOddOfDigits(int absValue)
        {
            int copyAbsValue = absValue;
            int sum = 0;
            while (copyAbsValue > 0)
            {
                int lastNumber = copyAbsValue % 10;
                copyAbsValue /= 10;
                if (lastNumber % 2 != 0)
                {
                    sum += lastNumber;
                }
            }
            return sum;
        }
    }
}
