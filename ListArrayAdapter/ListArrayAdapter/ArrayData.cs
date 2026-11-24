namespace ListArrayAdapter
{
    public class ArrayData : IArrayData
    {
        private int[] items;

        public ArrayData(int size)
        {
            items = new int[size];
        }

        public int GetLength()
        {
            return items.Length;
        }

        public int GetItem(int index)
        {
            return items[index];
        }

        public void SetItem(int index, int value)
        {
            items[index] = value;
        }

        public int[] ToArray()
        {
            return (int[])items.Clone();
        }
    }
}
