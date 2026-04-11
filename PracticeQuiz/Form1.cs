namespace PracticeQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   

        private void btnItem1_Click(object sender, EventArgs e)
        {
            txtPrice.Text = 12.00.ToString();
            txtDiscount.Text = "0.00%";
        }

        private void btnItem2_Click(object sender, EventArgs e)
        {
            txtPrice.Text = 20.50.ToString();
            txtDiscount.Text = "5.00%";
        }
        private void btnItem3_Click (object sender, EventArgs e)
        {
            txtPrice.Text = 100.00.ToString();
            txtDiscount.Text = "7.00%";
        }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuality.Text))
            {
                MessageBox.Show("Please enter a quantity.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuality.Focus();
                return;
            }

            if (!double.TryParse(txtQuality.Text, out double Quantity) || Quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than zero.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuality.Focus();
                return;
            }

            double Price = double.Parse(txtPrice.Text);
            double Discount = double.Parse(txtDiscount.Text.TrimEnd('%'))/100;
            double Quality = double.Parse(txtQuality.Text);

            double vatRate = 0.12;
            double discountedPrice = Price - (Price * Discount);
            double vatableAmount = discountedPrice * Quantity;
            double vatAmount = vatableAmount * vatRate;
            double totalAmount = vatableAmount + vatAmount;
            txtViaAmount.Text = vatableAmount.ToString("N2");
            txtVia.Text = vatAmount.ToString("N2");
            txtTotalAmount.Text = totalAmount.ToString("N2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                foreach (Control childControl in control.Controls)
                {
                    if (childControl is TextBox)
                    {
                        childControl.Text = string.Empty;
                    }
                }
            }
        }

        private void txtQuality_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtViaAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
