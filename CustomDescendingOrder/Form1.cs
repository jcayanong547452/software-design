using System;
using System.Windows.Forms;
namespace CustomDescendingOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] DescendingSorter(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
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
        public void btnSort_click(object sender, EventArgs e)
        {
            int[] number = { 30, 10, 50, 20, 40
            };
            int[] sortedNumbers = DescendingSorter(number);
            ListBoxResult.DataSource = sortedNumbers;
        }

    }
}

