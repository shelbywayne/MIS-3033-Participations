using System;

namespace MoreDifficultClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student(5, "Shelby", "Williams", 15000);
            myStudent.MakePayment(500);
            Console.WriteLine(myStudent);

            try
            {
                myStudent.MakePayment(-500);
                Console.WriteLine(myStudent);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
