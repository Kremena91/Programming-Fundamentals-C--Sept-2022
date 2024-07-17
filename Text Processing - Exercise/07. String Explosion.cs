using System;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textField = Console.ReadLine();
            // Step 1 => създаваме променлива за бомбата
            int bomb = 0;
            // Step 2 => да преминем през текста за да проверим за бомба
            for (int i = 0; i < textField.Length; i++)
            {
                // Step 3 проверяваме дали имаме бомба с по-голяма стойност от 0 и е различна от '>'
                if (bomb > 0 && textField[i] != '>')
                {
                    textField = textField.Remove(i, 1); // променяме текста като премахваме текущото място на което се намираме (i е индекса на който се намира, а 1 е дължината)
                    bomb--; //  намаляме бомбите, т.е. намаляме силата 
                    i--; // връщаме се една стъпка назад, защото трябва да сме на знака '>' след като сме унищожили бомбата
                }

                //Step 3.1 ако индекса на текущия символ е '>' тогава ние сме намерили експлозия и тогава ние трябва да я добавим към силата на бомбите, които имаме
                else if (textField[i] == '>')
                {
                    bomb += int.Parse(textField[i + 1].ToString()); // вземаме i+1, защото на i е знака '>', а на i+1 е числото
                }
            }
            Console.WriteLine(textField);
        }
    }
}
