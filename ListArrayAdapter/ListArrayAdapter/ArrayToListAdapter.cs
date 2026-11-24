using System;
using System.Collections.Generic;

namespace ListArrayAdapter
{
    public class ArrayToListAdapter : IListData
    {
        private ArrayData array;

        public ArrayToListAdapter(ArrayData array)
        {
            this.array = array;
        }

        public int Count()
        {
            return array.GetLength();
        }

        public int Get(int index)
        {
            return array.GetItem(index);
        }

        public void Set(int index, int value)
        {
            array.SetItem(index, value);
        }

        public void Add(int value)
        {
            throw new InvalidOperationException("Масив не динамічний: його розмір не можна змінити, тому додати елемент неможливо.");
        }

        public List<int> ToList()
        {
            List<int> result = new List<int>();
            for (int i = 0; i < array.GetLength(); i++)
            {
                result.Add(array.GetItem(i));
            }
            return result;
        }
    }
}
