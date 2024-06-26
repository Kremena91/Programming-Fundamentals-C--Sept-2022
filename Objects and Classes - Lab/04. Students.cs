using System;
using System.Collections.Generic;
using System.Linq;
 
namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>(); // пазим всички студенти в един лист

            while (input != "end")
            {
                //John Smith 15 Sofia
                string[] personInfo = input.Split();

                string firstName = personInfo[0];
                string lastName = personInfo[1];
                int age = int.Parse(personInfo[2]);
                string town = personInfo[3];

                Student student = new Student(firstName, lastName, age, town); // обекта
                students.Add(student); // всеки студент го добавяме към колекцията students

                input = Console.ReadLine();
            }

            string desiredTown = Console.ReadLine(); // четем името на града
            // трябва да намерим всички студенти от този град който търсим
            foreach (Student currentStudent in students) 
            {
                if (currentStudent.Town == desiredTown) // ако града на настоящия студент е равен на търсения град
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, int age, string town)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Town = town;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }
    }
}
