using System;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read the input from the console
            string[] usernames = Console.ReadLine().Split(", ");
            // interate throug all the usernames 
            foreach (string currName in usernames)
            {
                // sh // pesho
                if (currName.Length > 3 && currName.Length <= 16)
                {
                    // check if the userName is valid 
                    bool isUsarnameValid = true; // всяко име, което мине проверката за брой символи, първоначално ще бъде валидно
                    foreach (char currChar in currName) // => връща масив charrArray = [s, h]
                                                        // => [p, e, s, h, o]
                    {
                        if (!(char.IsLetterOrDigit(currChar) || currChar == '-' || currChar == '_')) // ако не съдържа буква или цифра или тире или долна черта
                        {
                            isUsarnameValid = false;
                            break;
                        }
                    }
                    if (isUsarnameValid)// ако е валидно принтираме
                    {
                        Console.WriteLine(currName); // pesho
                    }
                }
            }
        }
    }
}
