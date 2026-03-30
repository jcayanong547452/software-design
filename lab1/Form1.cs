namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] ProceduralSort(int[] numbers)
        {
            Array.Sort(numbers);
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
