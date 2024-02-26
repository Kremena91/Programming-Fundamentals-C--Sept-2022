using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n]; // колкото двойки прочетем, толкова трябва да ни е дължината на масива
            int[] array2 = new int[n];
            for (int i = 1; i <= n; i++)
            {
                int[] numbers = Console.ReadLine() // масив
                .Split().
                Select(int.Parse).
                ToArray();
                int firstNum = numbers[0]; // вземаме първото число от двойката в масива
                int secondNum = numbers[1]; // вземаме второто число от двойката в масива
                if (i % 2 != 0) // всeки нечетен ред от числа, първото число отива в първия масив, а второто число във втория масив
                {
                    array1[i-1] = firstNum;
                    array2[i-1] = secondNum;
                }
                else // всяко четен ред от числа второто число отива в първия масив, а първото число във втория масив
                {
                    array1[i-1] = secondNum;
                    array2[i-1] = firstNum;
                }
            }
            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));
        }
    }
}

