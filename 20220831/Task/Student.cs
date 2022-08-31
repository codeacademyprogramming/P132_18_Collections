using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class Student
    {

        private static int _totalCount;

        public Student()
        {
            _totalCount++;

            No = 100 + _totalCount;
        }

        public int No;
        public string Name;
        public string GroupNo;
        public byte Point;

    }
}
