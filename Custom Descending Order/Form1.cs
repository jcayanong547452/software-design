using System;
using System.Windows.Forms;

namespace Custom_Descending_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sorts array in DESCENDING order (OOP method)
        public int[] DescendingSorter(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    // Change > to < for descending order
                    if (numbers[j] < numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] number = { 30, 10, 50, 20, 40 };

            // Show unsorted

            // Show sorted in descending order
            int[] sortedNumbers = DescendingSorter(number);
            ListBoxResult.DataSource = sortedNumbers;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}