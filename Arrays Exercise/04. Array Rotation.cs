using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine() 
                .Split().
                Select(int.Parse).
                ToArray();
            int rotationsCount = int.Parse(Console.ReadLine());
            int timesToRotate = rotationsCount % array.Length; // за оптимизация на кода
            for (int r = 1; r <= timesToRotate; r++) // обхождаме броя ротации
            {
                int firstNumber = array[0];
                for (int i = 1; i < array.Length; i++) // обхождаме числата
                {
                    array[i-1] = array[i]; // всяко число трябва да мине с един индекс назад, т.е. от 1 да отиде на 0, от 2 да отиде на 1 и т.н.
                }
                array[array.Length - 1] = firstNumber; // на последната позиция се поставя първото число
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
