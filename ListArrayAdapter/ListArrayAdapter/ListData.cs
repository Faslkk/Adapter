using System.Collections.Generic;

namespace ListArrayAdapter
{
    public class ListData : IListData
    {
        private List<int> items = new List<int>();

        public int Count()
        {
            return items.Count;
        }

        public int Get(int index)
        {
            return items[index];
        }

        public void Set(int index, int value)
        {
            items[index] = value;
        }

        public void Add(int value)
        {
            items.Add(value);
        }

        public List<int> ToList()
        {
            return new List<int>(items);
        }
    }
}
