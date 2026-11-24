using System.Collections.Generic;

namespace ListArrayAdapter
{
    public interface IListData
    {
        int Count();
        int Get(int index);
        void Set(int index, int value);
        void Add(int value);
        List<int> ToList();
    }
}
