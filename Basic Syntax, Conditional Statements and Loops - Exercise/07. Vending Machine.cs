using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();
            double sum = 0;
            double price = 0;

            while (money != "Start")
            {
                if (money == "0.1")
                {
                    double num = double.Parse(money);
                    sum += num;
                }
                else if (money == "0.2")
                {
                    double num = double.Parse(money);
                    sum += num;
                }
                else if (money == "0.5")
                {
                    double num = double.Parse(money);
                    sum += num;
                }
                else if (money == "1")
                {
                    double num = double.Parse(money);
                    sum += num;
                }
                else if (money == "2")
                {
                    double num = double.Parse(money);
                    sum += num;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                money = Console.ReadLine();
            }
            if (money == "Start")
            {
                string product = Console.ReadLine();
                while (product != "End")
                {
                    if (product == "Nuts")
                    {
                        price = 2.0;
                        if (sum >= price)
                        {
                            Console.WriteLine($"Purchased nuts");
                            sum -= price;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                    }
                    else if (product == "Water")
                    {
                        price = 0.7;
                        if (sum >= price)
                        {
                            Console.WriteLine($"Purchased water");
                            sum -= price;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                    }
                    else if (product == "Crisps")
                    {
                        price = 1.5;
                        if (sum >= price)
                        {
                            Console.WriteLine($"Purchased crisps");
                            sum -= price;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                    }
                    else if (product == "Soda")
                    {
                        price = 0.8;
                        if (sum >= price)
                        {
                            Console.WriteLine($"Purchased soda");
                            sum -= price;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                    }
                    else if (product == "Coke")
                    {
                        price = 1.0;
                        if (sum >= price)
                        {
                            Console.WriteLine($"Purchased coke");
                            sum -= price;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid product");
                    }

                    product = Console.ReadLine();
                }
                if (product == "End")
                {
                    Console.WriteLine($"Change: {sum:f2}");
                }
            }

        }
    }
}