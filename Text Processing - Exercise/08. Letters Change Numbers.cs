using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); // => [ A12b, s17G]
            double sum = 0;

            // с foreach минаваме през всички елементи на масива и извършваме събиране, изваждане, умножение и деление
            foreach (string item in input)
            {
                char firstLetter = item[0]; // A
                char lastLetter = item[item.Length -1]; // this is the same as item[^1] ==> b

                // string numAsAString = item[1..^1]; // това ще ни даде всичко, което е между 0 и последния индекс; => 12
                // double numFromString = double.Parse(numAsAString); //12
                double numFromString = double.Parse(item.Substring(1, item.Length - 2)); // (задаваме от 1-ва позиция до дължината - 2, тъй като първия и последен символ са винаги букви) това ще ни даде всичко, което е между 0 и последния индекс като число; => 12

                if (char.IsUpper(firstLetter)) // Ako първата буква е главна
                {
                    int postionOfTheLetter = firstLetter - 64; // от 64 започва главната буква в ASSCI таблицата (намираме на коя пизиця се намира буквата)
                    numFromString /= postionOfTheLetter;
                }
                else // в противен случай е малка буква
                {
                    int positionOfTheLetter = firstLetter - 96; // от 96 започва малката буква в ASSCI таблицата (намираме на коя пизиця се намира буквата)
                    numFromString *= positionOfTheLetter;
                }

                if (char.IsUpper(lastLetter)) // Ako последната буква е главна
                {
                    int positionOfTheLetter = lastLetter - 64;
                    numFromString -= positionOfTheLetter;
                }
                else // в противен случай е малка буква
                {
                    int positionOfTheLetter = lastLetter - 96;
                    numFromString += positionOfTheLetter;
                }
                sum += numFromString;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
