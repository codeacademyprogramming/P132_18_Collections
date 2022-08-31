using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class MyList<T> where T:class
    {
        private T[] _arr = new T[0];

        public void Add(T value)
        {
            System.Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }   

        public T this[int index]
        {
            get
            {
                return _arr[index];
            }
            set
            {
                _arr[index] = value;
            }
        }
        public T[] Array => _arr;
    }
}
