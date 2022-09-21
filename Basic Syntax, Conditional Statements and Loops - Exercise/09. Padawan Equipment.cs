using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            double lightsabersCount = Math.Ceiling(studentsCount + studentsCount*0.10); // или 100% + 10% = 110 % = 1.1 (studentsCount*1.1)
            lightsabersCount = Math.Ceiling(lightsabersCount);
            int belts = studentsCount / 6; // връща цяло число и няма нужда от if проверка дали числото мдулно се дели на 6
            double totalPrice = lightsabersCount * lightsabersPrice + robesPrice * studentsCount + (studentsCount-belts)*beltsPrice ;
            if (totalPrice <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalPrice - amountOfMoney):f2}lv more.");
            }
        }
    }
}
