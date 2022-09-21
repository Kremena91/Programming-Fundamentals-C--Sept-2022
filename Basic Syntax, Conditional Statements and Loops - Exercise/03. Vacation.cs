using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            if (typeOfGroup == "Students")
            {
                switch (day)
                {
                    case "Friday":
                        price = countOfPeople * 8.45;
                        if (countOfPeople >= 30)
                        {
                            price = price - (price * 0.15);
                        }
                        break;
                    case "Saturday":
                        price = countOfPeople * 9.80;
                        if (countOfPeople >= 30)
                        {
                            price = price - (price * 0.15);
                        }
                        break;
                    case "Sunday":
                        price = countOfPeople * 10.46;
                        if (countOfPeople >= 30)
                        {
                            price = price - (price * 0.15);
                        }
                        break;
                }
            }
            else if (typeOfGroup == "Business")
            {
                switch (day)
                {
                    case "Friday":
                        price = countOfPeople * 10.90;
                        if (countOfPeople >= 100)
                        {
                            price = (countOfPeople - 10) * 10.90;
                        }
                        break;
                    case "Saturday":
                        price = countOfPeople * 15.60;
                        if (countOfPeople >= 100)
                        {
                            price = (countOfPeople - 10) * 15.60;
                        }
                        break;
                    case "Sunday":
                        price = countOfPeople * 16.00;
                        if (countOfPeople >= 100)
                        {
                            price = (countOfPeople - 10) * 16.00;
                        }
                        break;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                switch (day)
                {
                    case "Friday":
                        price = countOfPeople * 15.00;
                        if (countOfPeople >= 10 && countOfPeople<=20)
                        {
                            price = price - (price * 0.05);
                        }
                        break;
                    case "Saturday":
                        price = countOfPeople * 20.00;
                        if (countOfPeople >= 10 && countOfPeople <= 20)
                        {
                            price = price - (price * 0.05);
                        }
                        break;
                    case "Sunday":
                        price = countOfPeople * 22.50;
                        if (countOfPeople >= 10 && countOfPeople <= 20)
                        {
                            price = price - (price * 0.05);
                        }
                        break;
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
