using System;
using System.Collections.Generic;

namespace Onsdag2022_10_26_listexempel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> liststud = new List<Student>();
            Student S1 = new Student()
            {
                Id = 110,
                Name = "Reidar",
                Gender = "m",
                Salary = 3500
            };
            Student S2 = new Student()
            {
                Id = 111,
                Name = "Albertine",
                Gender = "f",
                Salary = 35000
            };
            Student S3 = new Student()
            {
                Id = 112,
                Name = "Tyson",
                Gender = "m",
                Salary = 21200
            };
            Student S4 = new Student()
            {
                Id = 113,
                Name = "Albert",
                Gender = "m",
                Salary = 41900
            };
            liststud.Add(S1);
            liststud.Add(S2);
            liststud.Add(S3);
            liststud.Add(S4);

            ////indexof
            //Console.WriteLine(liststud.IndexOf(S2));
            ////Insert
            //liststud.Insert(1, S3);
            //Console.WriteLine(liststud.IndexOf(S2));
            ////contains
            //if (liststud.Contains(S4))
            //{
            //    Console.WriteLine("Yes S4");
            //}
            //else
            //{
            //    Console.WriteLine("No S4");
            //}
            //(s => logisk operation)
            //find
            //Student student = liststud.Find(ls => ls.Salary >= 30000);
            //Console.WriteLine($"ID={student.Id} Name={student.Name} Gender={student.Gender} Salary= {student.Salary}");
            //findlast
            //Student student = liststud.FindLast(ls => ls.Salary >= 30000);
            //Console.WriteLine($"ID={student.Id} Name={student.Name} Gender={student.Gender} Salary= {student.Salary}");
            //findall
            //List<Student> student = liststud.FindAll(ls => ls.Salary >= 30000);
            //foreach (Student stud in student)
            //{
            //    Console.WriteLine($"ID={stud.Id} Name={stud.Name} Gender={stud.Gender} Salary= {stud.Salary}");
            //}
            //Find index
            int indexof = liststud.FindIndex(k => k.Salary <= 5000);
            Console.WriteLine("Index = " + indexof);
        }
    }
}
