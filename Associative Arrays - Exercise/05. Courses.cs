using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Key -> името на курса
            //Value -> лист от записаните студенти в този курс List<Usernames>

            Dictionary<string, List<string>> coursesInfo =
                new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = cmdArgs[0];
                string studentName = cmdArgs[1];

                if (!coursesInfo.ContainsKey(courseName)) // Ако във речника не се съдържа такъв ключ
                {
                    //Никога не трябва да забравяме да инстанцираме Value, когато е List, Array, Class, Dictionary
                    coursesInfo[courseName] = new List<string>(); // трябва на този ключ да зададем празен списък (инстанцираме)
                }// щом не се съдържа за ключ слагаме името на курса, а за стойност празен списък

                //Here we are sure that we already have created instance for the value
                coursesInfo[courseName].Add(studentName);
                // дай ми ст-та, която стои срещу съответния курс, то връща празен списък и му казваме в този списък добави този студент
            }

            foreach (var kvp in coursesInfo)
            {
                string courseName = kvp.Key;
                List<string> students = kvp.Value;

                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (string studentName in students) // с вложен foreach отпечатваме всеки студент от студентите
                {
                    Console.WriteLine($"-- {studentName}"); 
                }
            }
        }
    }
}
