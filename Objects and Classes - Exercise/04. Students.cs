using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    public class Program
    {
        static void Main(string[] args)
        {
            // създаване на масиви или обекти 
            //Array of objects from class Student
            //Student[] studentsArr = new Student[5];
            //Array of random objects with random properties - масив от произволни обекти
            //object[] objArr = new object[5];
            
            List<Student> students = new List<Student>(); // правим колекция от обекти

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = cmdArgs[0];
                string lastName = cmdArgs[1];
                double grade = double.Parse(cmdArgs[2]);

                Student currStudent = new Student(firstName, lastName, grade); // създ. обект,  типа данни на инстанцията е самият клас
                students.Add(currStudent);
            }

            // механизъм за сменяне на стойоноста на пропърти е:
            // students[0].FirstName = "Pesho"; като в пропъртито трябва да е set, a не private set

            List<Student> orderedStudents = students // създ. списък с подредените студенти по оценка
                .OrderByDescending(s => s.Grade)
                .ToList();
            //students = students - ако не искаме да правим втори списък
            //    .OrderByDescending(s => s.Grade)
            //    .ToList();
            //foreach (Student student in orderedStudents)
            //{
            //    Console.WriteLine(student);
            //}

            foreach (Student student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }

    public class Student
    {
        // конструктор
        public Student(string firstName, string lastName, double grade) // за всяко едно пропърти за което искаме отвън да дойде информация трябва да бъде описано тук през конструктора
        {
            this.FirstName = firstName; // казваме в пропъртито през сетъра искаме да пазим тази стойност в конструктора, която идва като най-обикновен параметър на метода
            this.LastName = lastName;
            this.Grade = grade;
        }

        // пропъртита
        public string FirstName { get; private set; } // private set, означава че никой не може да променя отвън

        public string LastName { get; private set; }

        public double Grade { get; private set; }

        //public override string ToString()
        //{
            // тук нямаме конкретна инстанция, тук this сочи към конкретната инстанция
        //    return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        //}
    }
}
