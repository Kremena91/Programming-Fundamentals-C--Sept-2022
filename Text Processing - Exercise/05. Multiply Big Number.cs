using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // 23; 9999
            int mulitplier = int.Parse(Console.ReadLine()); // 2; 9
            StringBuilder sb = new StringBuilder(); // създава празен stringBuilder, който ще ни даде методи, които можем да използваме за да изградим нашия стринг 
            int reminder = 0; // ако имаме остатък при деление
            
            // случай при който поттребителя въведе 0 или умножи по 0
            if (mulitplier == 0 || input == "0")
            {
                Console.WriteLine(0); // автоматично да върне 0
                return; // и да прекрати без да прави изчисленията надолу
            }

            for (int i = input.Length - 1; i >= 0; i--) // 23 ==> 32 (обръщаме числата наобратно)
            {                                           // 9999 ==> 9999
                int currDigit = int.Parse(input[i].ToString()); // 3 (превръща го от текст в число); 9
                int product = currDigit * mulitplier + reminder; // 9* 9 = 81
                int result = product % 10; // 81 % 10 => 1
                reminder = product / 10; // остатък 8
                sb.Insert(0, result);
            }

            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
