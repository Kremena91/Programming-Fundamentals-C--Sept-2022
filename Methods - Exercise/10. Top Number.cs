using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (devisibleByEigth(i) && oddDigit(i))
                {
                    Console.WriteLine(i);
                }

            }
        }
            static bool devisibleByEigth(int num)
            {

                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if (sum % 8 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            static bool oddDigit(int num)
            {

                int count = 0;
                while (num > 0)
                {
                    if ((num % 10) % 2 == 1)
                    {
                        count++;
                    }
                    num /= 10;
                }
                if (count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }