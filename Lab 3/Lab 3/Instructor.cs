using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Instructor
    {
        private string Name;
        private string CourseName;


        public Instructor(string Name, string CourseName)
        {
            this.Name = Name;
            this.CourseName = CourseName;
        }

        public void SetStudentGrade(Student student, int Grade)
        {
            student.Setgrade(Grade);
        }

    }
}
