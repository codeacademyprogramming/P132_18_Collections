using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    internal struct Student
    {
        public Student(string name)
        {
            Name = name;
        }

        public Student(int age)
        {
            Name = null;
        }
        public string Name;
    }
}
