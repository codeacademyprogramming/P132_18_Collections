using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class MyIntList
    {
        private int[] _arr = new int[0];

        public void Add(int value)
        {
            System.Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }

        public int[] Array => _arr;
    }
}
