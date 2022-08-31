using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class MyHumanList
    {
        private Human[] _arr = new Human[0];

        public void Add(Human value)
        {
            System.Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }

        public Human[] Array => _arr;
    }
}
