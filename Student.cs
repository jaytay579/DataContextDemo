using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextDemo
{
    public class Student
    {
        public Student(string s)
        {
            studentname = s;
        }

        private string studentname;
        public string StudentName
        {
            get
            {
                return studentname;
            }
            set
            {
                studentname = value;
            }
        }
    }
}
