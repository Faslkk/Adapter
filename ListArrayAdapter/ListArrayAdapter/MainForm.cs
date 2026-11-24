using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ListArrayAdapter
{
    public partial class MainForm : Form
    {
        private ListData list = new ListData();
        private ArrayData array = new ArrayData(0);

        public MainForm()
        {
            InitializeComponent();
            txtArrayValues.Text = "10 20 30 40";
        }

        private void btnListAdd_Click(object sender, EventArgs e)
        {
            int value;
            if (!int.TryParse(txtListValue.Text, out value))
            {
                MessageBox.Show("Введіть ціле число.");
                return;
            }
            list.Add(value);
            txtListValue.Text = "";
            ShowList(list);
            lblInfo.Text = "До списку додано " + value + ". Елементів у списку: " + list.Count();
        }

        private void btnArrayCreate_Click(object sender, EventArgs e)
        {
            string[] parts = txtArrayValues.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ArrayData newArray = new ArrayData(parts.Length);
            for (int i = 0; i < parts.Length; i++)
            {
                int value;
                if (!int.TryParse(parts[i], out value))
                {
                    MessageBox.Show("Введіть цілі числа через пробіл.");
                    return;
                }
                newArray.SetItem(i, value);
            }
            array = newArray;
            ShowArray(array);
            lblInfo.Text = "Створено масив розміром " + array.GetLength() + ". Розмір масиву більше не змінюється.";
        }

        private void btnListToArray_Click(object sender, EventArgs e)
        {
            IArrayData adapter = new ListToArrayAdapter(list);
            int[] items = adapter.ToArray();

            array = new ArrayData(items.Length);
            for (int i = 0; i < items.Length; i++)
            {
                array.SetItem(i, items[i]);
            }
            ShowArray(array);
            lblInfo.Text = "ListToArrayAdapter: список з " + list.Count() + " елементів перетворено в масив розміром " + array.GetLength() + ".";
        }

        private void btnArrayToList_Click(object sender, EventArgs e)
        {
            IListData adapter = new ArrayToListAdapter(array);
            List<int> items = adapter.ToList();

            list = new ListData();
            foreach (int item in items)
            {
                list.Add(item);
            }
            ShowList(list);
            lblInfo.Text = "ArrayToListAdapter: масив розміром " + array.GetLength() + " перетворено в список з " + list.Count() + " елементів.";
        }

        private void btnAdapterAdd_Click(object sender, EventArgs e)
        {
            int value;
            if (!int.TryParse(txtAddValue.Text, out value))
            {
                MessageBox.Show("Введіть ціле число.");
                return;
            }

            IListData adapter = new ArrayToListAdapter(array);
            try
            {
                adapter.Add(value);
            }
            catch (InvalidOperationException ex)
            {
                lblInfo.Text = "ArrayToListAdapter.Add(): " + ex.Message;
                MessageBox.Show(ex.Message, "Масив не динамічний");
            }
        }

        private void ShowArray(IArrayData data)
        {
            lstArray.Items.Clear();
            for (int i = 0; i < data.GetLength(); i++)
            {
                lstArray.Items.Add("[" + i + "] = " + data.GetItem(i));
            }
        }

        private void ShowList(IListData data)
        {
            lstList.Items.Clear();
            for (int i = 0; i < data.Count(); i++)
            {
                lstList.Items.Add((i + 1) + ". " + data.Get(i));
            }
        }
    }
}
