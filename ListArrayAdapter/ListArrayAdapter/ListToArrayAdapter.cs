namespace ListArrayAdapter
{
    public class ListToArrayAdapter : IArrayData
    {
        private ListData list;

        public ListToArrayAdapter(ListData list)
        {
            this.list = list;
        }

        public int GetLength()
        {
            return list.Count();
        }

        public int GetItem(int index)
        {
            return list.Get(index);
        }

        public void SetItem(int index, int value)
        {
            list.Set(index, value);
        }

        public int[] ToArray()
        {
            int[] result = new int[list.Count()];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = list.Get(i);
            }
            return result;
        }
    }
}
