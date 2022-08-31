using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class MyStringList
    {
        private string[] _arr = new string[0];

        public void Add(string value)
        {
            System.Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }

        public string[] Array => _arr;


        



    }
}
