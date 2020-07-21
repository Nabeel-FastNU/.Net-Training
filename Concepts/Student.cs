using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public Student() { }

        public Student(string s, int m)
        {
            Name = s;
            Marks = m;
        }

        //Lambda Expressions 

        public Func<Student, bool> checkPass = (s) => s.Marks > 50;

        public bool isFailed() => Marks < 50;

    }
}
