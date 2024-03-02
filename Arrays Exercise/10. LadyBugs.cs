using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.  инициализираме празно поле
            int fieldSize = int.Parse(Console.ReadLine()); // размер на полето
            int[] field = new int[fieldSize]; // това е създаденото празно поле
            // 2. поставяме калинки на валидните индекси
            int[] initialIndexes = Console.ReadLine() // началните индекси на всички калинки, колекцията не се променя, затова ще използваме foreach
                .Split().
                Select(int.Parse).
                ToArray();
            foreach (int index in initialIndexes) // за всеки един от индексите трябва да инициализираме на полето калинка
            {
                if (index >=0 && index < field.Length) // за всеки един индекс проверяваме дали е валиден (това са валидните случаи)
                {
                    // щом е валиден, трябва да инициализираме калинка на този индекс (на полето на този индекс слагаме 1, за да се знае, че има калинка)
                    field[index] = 1;
                }
            }
            // 3. Стартираме играта
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command // получения стринг като команда чрез насив го разделяме, за да достъпим всеки един аргумент
                    .Split()
                    .ToArray();
                // създаваме променливи за трите команди
                int ladyBugIndex = int.Parse(arguments[0]);
                string direction = arguments[1]; // посоката на летене
                int flyLength = int.Parse(arguments[2]);

                // 3.1. Валидираме дали калинката не е извън полето (винаги първо се валидира дали индекса е в масива и след това се проверява какво има на този индекс)
                if (ladyBugIndex < 0 || ladyBugIndex >= field.Length) // невалидните случаи
                {
                    // при невалиден индекс по условие нищо не се случва
                    continue; // за да скипнем тази команда (continue връща до while)
                }

                // 3.2. Валидираме, че има калинка на този индекс
                if (field[ladyBugIndex] == 0)
                {
                    continue; // скипваме командата, нищо не се случва (continue връща до while)
                }

                // 3.3. Опитваме да преместим калинка 
                // надясно - ladyBugIndex + flyLength
                // наляво - ladyBugIndex - flyLength
                // Първо трябва да махнем нашата калинка от полето, защото тя започва да лети, т.е. напуска полето и е някъде във въздуха
                field[ladyBugIndex] = 0; // защото калинката е излетяла
                // Второ трябва да калкулираме къде точно ще се преземи тази калинка взависимост от посоката
                if (direction == "left")
                {
                    flyLength *= -1;
                }
                // това ще работи и за ляво и дясно
                // при дясно напр. 0 right 1 -> 0 + 1 = 1
                // при ляво напр. 1 left 1 -> 1 + (-1) = 0
                int nextIndex = ladyBugIndex + flyLength;
                // докато слеващия индекс е валиден и на него има калинка
                while (nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 1)
                {
                    nextIndex += flyLength; // следващия индекс се преизчислява
                }
                // Има две възможности
                // а) nextIndex е калкулиран някъде в полето
                // б) nextIndex не може да се калкулира в полето
                if (nextIndex < 0 || nextIndex >= field.Length) // т.е. ако сме излезнали от полето
                {
                    // б) извън полето
                    continue; // нищо не се случва
                }
                // а) ако сме калкулиран следващ индекс, който е валиден
                field[nextIndex] = 1; // равно на 1, защото калинката се приземява там
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
