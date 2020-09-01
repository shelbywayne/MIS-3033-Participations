using ClassesandFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Participation3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Student newstud = new Student();
            newstud.name = Console.ReadLine();
            Console.WriteLine("What is your ID number?");
            newstud.id = Convert.ToInt32(Console.ReadLine());
            List<Student> students = new List<Student>();
            students.Add(newstud);

            foreach (var stud in students)
            {
                Console.WriteLine(stud);

            }


            Student stud2 = new Student("Micah", 1);

        }
    }
}
