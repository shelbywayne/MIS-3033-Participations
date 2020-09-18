using System;
using System.Collections.Generic;
using System.Text;

namespace MoreDifficultClassesExample
{
    class Student
    {
        public int SoonerID { get; set; }          
        public string FirstName { get; set; }      
        public string LastName { get; set; }       
        public bool IsOnProbation { get; set; }    
        public double GPA { get; set; }
        private double BursarBalance;
        
        public Student()
        {
            SoonerID = '1';
            FirstName = "";
            LastName = String.Empty;
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 10000;
        }

        public Student (int id, string firstName, string lastName, double BursarBalance)
        {
            SoonerID = id;
            FirstName = firstName;
            LastName = lastName;
            IsOnProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance;
        }

        public void MakePayment(double amount)
        {
            if (amount >0)
            {
                BursarBalance = BursarBalance - amount;
            }
            else
            {
                throw new Exception("invalid payment response");
            }
        }

        public double CheckBalance()
        {
            return BursarBalance;
        }

        public override string ToString()
        {
            string result = $"{FirstName} {LastName} ({SoonerID}) has a GPA of {GPA} and has a balance of {BursarBalance} on their Bursar account.";

            if (IsOnProbation == true)
            {
                result += "\nIs on probation";
            }
            else
            {
                result += "\nIs not on probation.";
            }

            return result;

        }
    }
}
