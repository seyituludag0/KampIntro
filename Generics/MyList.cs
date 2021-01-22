using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class MyList<T>
    {
        T[] _array;

        public MyList()
        {
            _array = new T[0];
        }
       
        public void Add(T item)
        {
            T[] tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                _array[i] = tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get
            {
                return _array.Length;
            }
        }
    }
}
