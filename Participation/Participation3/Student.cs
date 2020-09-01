using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ClassesandFiles
{
    class Student
    {
        public string name { get; set; }
        public int id { get; set; }
        private static int totalStudents { get; set; }

        public Student ( string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public Student()
        {
            name = "";
            id = 0;
        }

        public string getName ()
        {
            return name;
        }

        private stat
    
    }
}
