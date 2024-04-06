using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> guestList = new List<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine() // създаваме масив от стрингове
                    .Split();
                string name = cmdArg[0]; // името се намира на нулев индекс

                if (cmdArg.Length == 3) // дължината на масива, показва коя команда сме получили; is going
                {
                    if (guestList.Contains(name)) // // проверява дали съдържа това име
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else if (cmdArg.Length == 4) // is not going
                {
                    if (!guestList.Contains(name)) // проверява дали не съдържа това име
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        guestList.Remove(name);
                    }
                }              
            }
            Console.WriteLine(string.Join(Environment.NewLine, guestList));

        }
    }
}

// static void PrintGuestList(List<string> guestList)
//{
//Change in the list here will be appended in the Main()
//  foreach (string name in guestList)
//  {
//        Console.WriteLine(name);
//  }
// }

//  static void PrintGuestListAlphabetically(List<string> guestList)
//           {
            //OrderByDescending = OrderBy + Reverse
         //   List<string> orderedList = guestList
          //      .OrderBy(e => e) //Will learn it later in the course!
          //      .ToList();
          //  foreach (string name in orderedList)
          //  {
             //   Console.WriteLine(name);
           // }
        
