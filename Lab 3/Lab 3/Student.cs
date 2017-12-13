using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student(string Name, Instructor Teacher)
        {
            this.Name = Name;
            this.Grade = 0;
            this.Teacher = Teacher;
        }

        public int SetGrade(int Grade)
        {
            return this.Grade = Grade;
        }

        public void StudentPrint()
        {
            System.Console.WriteLine(this.Name);
            System.Console.WriteLine(this.Grade);
            Teacher.Print();
        }
    }
}
