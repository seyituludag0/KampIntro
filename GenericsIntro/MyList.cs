using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] _items;

        public MyList()
        {
            _items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = _items;
            _items = new T[_items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = _items[i];
            }

            _items[_items.Length - 1] = item;
        }

        public int Count
        {
            get
            {
                return _items.Length;
            }
        }

    }
}
