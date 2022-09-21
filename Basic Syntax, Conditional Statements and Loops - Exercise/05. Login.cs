using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;
            for (int i = userName.Length-1; i >= 0; i--) // обръщане на string в обратна последователност
            {
                char currentPassword = userName[i];
                password += currentPassword;
            }
            string input = Console.ReadLine(); 
            int count = 0;
            while (input != password)
            {
                count++;
                if (count >= 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
                input = Console.ReadLine();
            }
            if (count < 4)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        } 
    }
}
