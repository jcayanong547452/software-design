namespace RecursiveFibonnaciSequence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEnter.Text, out int n))
            {
                if (n < 0)
                {
                    MessageBox.Show("Please enter a non-negative integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int result = Fibonacci(n);
                txtResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int Fibonacci(int n)
        {
          
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}