using System;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
              public int[] ProceduralSort(int[] numbers)
                {


            /* Array.Sort(numbers);
             return numbers;*/
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Swap
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }


                }
            }
            return numbers;

        }
       
        
        //Winform Button click to display results
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] number = { 3, 1, 5, 2, 4 };
            int[] sortedNumbers = ProceduralSort(number);
            ListBoxResult.DataSource = sortedNumbers;
        }
    }


}
