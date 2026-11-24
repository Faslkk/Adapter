namespace ListArrayAdapter
{
    public interface IArrayData
    {
        int GetLength();
        int GetItem(int index);
        void SetItem(int index, int value);
        int[] ToArray();
    }
}
