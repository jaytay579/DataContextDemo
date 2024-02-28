using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextDemo
{
    class Course
    {
        public List<Student> Students;

        public Course()
        {
            Students = new List<Student>();
        }

        public void addStudent(Student s)
        {
            Students.Add(s);
        }
    }
}
