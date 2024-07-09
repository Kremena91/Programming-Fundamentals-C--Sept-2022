using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1 Converting string input "Peter George" in  string[] => ["Peter", "George] by using Spilt();
            string[] input = Console.ReadLine().Split();
            // Step 2 - Creating Method that takes two arguments string input[0] and input[1];
            GetStringSum(input[0], input[1]);
        }
        private static void GetStringSum(string stringOne, string stringTwo)
        {
            int sum = 0; // step 3 - създаваме sum = 0, в sum ще държим крайната сума от умножението/ добавяме последните символи, ако единият стринг е по-голям от другия
            // step 4 - откриваме кой е по-големият стринг като изполваме Math.Min(stringOne.length, stringTwo.length)
            int minLength = Math.Min(stringOne.Length, stringTwo.Length); // колко символа е мин. дължина
           
            for (int i = 0; i < minLength; i++) // step 5 създаваме цикъл от 0 до the minLength (стринга с най-малка дължина), за да може да минем и през двата стринга
            {
                sum += stringOne[i] * stringTwo[i];
            }

            string longestLegthString = stringOne; // първоначално казваме че първия стринг е с най-голяма дължина
            if (longestLegthString.Length < stringTwo.Length) // ако дължината на първия стринг е по-малка от тази на втория стринг
            {
                longestLegthString = stringTwo; // втория стринг става този с най-голяма дължина
            }
            for (int i = minLength; i < longestLegthString.Length; i++) // преминаваме от мин. дължина до дължината на най-големия стринг
            {
                sum += longestLegthString[i]; // добавяме символите
            }
            Console.WriteLine(sum);
        }
    }
}
