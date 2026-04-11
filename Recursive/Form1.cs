namespace RecursivePower
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Power(int x, int n)
        {
            if (n == 0)
                return 1;

            else
                return x * Power(x, n - 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {        
            if (!int.TryParse(txtBase.Text, out int x))
            {
                MessageBox.Show("Please enter a valid integer for the base.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtExponential.Text, out int n))
            {
                MessageBox.Show("Please enter a valid integer for the exponent.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (n < 0)
            {
                MessageBox.Show("Please enter a non-negative exponent.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int result = Power(x, n);
            txtResult.Text = result.ToString();
        }
    }
}