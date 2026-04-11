namespace PracticeQuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lbl2 = new Label();
            btnCompute = new Button();
            lbl1 = new Label();
            txtQuality = new TextBox();
            btnItem3 = new Button();
            btnItem2 = new Button();
            btnItem1 = new Button();
            groupBox2 = new GroupBox();
            lbl4 = new Label();
            lbl3 = new Label();
            txtDiscount = new TextBox();
            txtPrice = new TextBox();
            groupBox3 = new GroupBox();
            lbl7 = new Label();
            lbl6 = new Label();
            lbl5 = new Label();
            txtTotalAmount = new TextBox();
            txtVia = new TextBox();
            txtViaAmount = new TextBox();
            btnClear = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl2);
            groupBox1.Controls.Add(lbl1);
            groupBox1.Controls.Add(txtQuality);
            groupBox1.Controls.Add(btnItem3);
            groupBox1.Controls.Add(btnItem2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(btnItem1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 587);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Items";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(295, 282);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(25, 15);
            lbl2.TabIndex = 5;
            lbl2.Text = "/pc";
            // 
            // btnCompute
            // 
            btnCompute.Location = new Point(54, 53);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(137, 23);
            btnCompute.TabIndex = 3;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(23, 282);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(29, 15);
            lbl1.TabIndex = 4;
            lbl1.Text = "Qty.";
            // 
            // txtQuality
            // 
            txtQuality.Location = new Point(50, 279);
            txtQuality.Name = "txtQuality";
            txtQuality.Size = new Size(239, 23);
            txtQuality.TabIndex = 3;
            txtQuality.TextChanged += txtQuality_TextChanged;
            // 
            // btnItem3
            // 
            btnItem3.Location = new Point(23, 161);
            btnItem3.Name = "btnItem3";
            btnItem3.Size = new Size(298, 42);
            btnItem3.TabIndex = 2;
            btnItem3.Text = "Item3";
            btnItem3.UseVisualStyleBackColor = true;
            btnItem3.Click += btnItem3_Click;
            // 
            // btnItem2
            // 
            btnItem2.Location = new Point(22, 104);
            btnItem2.Name = "btnItem2";
            btnItem2.Size = new Size(299, 42);
            btnItem2.TabIndex = 1;
            btnItem2.Text = "Item2";
            btnItem2.UseVisualStyleBackColor = true;
            btnItem2.Click += btnItem2_Click;
            // 
            // btnItem1
            // 
            btnItem1.Location = new Point(23, 47);
            btnItem1.Name = "btnItem1";
            btnItem1.Size = new Size(299, 42);
            btnItem1.TabIndex = 0;
            btnItem1.Text = "Item1";
            btnItem1.UseVisualStyleBackColor = true;
            btnItem1.Click += btnItem1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbl4);
            groupBox2.Controls.Add(lbl3);
            groupBox2.Controls.Add(txtDiscount);
            groupBox2.Controls.Add(txtPrice);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(352, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 179);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(9, 103);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(54, 15);
            lbl4.TabIndex = 3;
            lbl4.Text = "Discount";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(20, 50);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(33, 15);
            lbl3.TabIndex = 2;
            lbl3.Text = "Price";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(69, 95);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(252, 23);
            txtDiscount.TabIndex = 1;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(69, 47);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(252, 23);
            txtPrice.TabIndex = 0;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbl7);
            groupBox3.Controls.Add(lbl6);
            groupBox3.Controls.Add(lbl5);
            groupBox3.Controls.Add(txtTotalAmount);
            groupBox3.Controls.Add(txtVia);
            groupBox3.Controls.Add(txtViaAmount);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(352, 179);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(388, 224);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Computation";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Location = new Point(20, 128);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(79, 15);
            lbl7.TabIndex = 5;
            lbl7.Text = "Total Amount";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Location = new Point(21, 90);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(51, 15);
            lbl6.TabIndex = 4;
            lbl6.Text = "VAT 12%";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(20, 48);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(94, 15);
            lbl5.TabIndex = 3;
            lbl5.Text = "VATable Amount";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(120, 125);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(246, 23);
            txtTotalAmount.TabIndex = 2;
            txtTotalAmount.TextChanged += txtTotalAmount_TextChanged;
            // 
            // txtVia
            // 
            txtVia.Location = new Point(120, 87);
            txtVia.Name = "txtVia";
            txtVia.ReadOnly = true;
            txtVia.Size = new Size(247, 23);
            txtVia.TabIndex = 1;
            txtVia.TextChanged += txtVia_TextChanged;
            // 
            // txtViaAmount
            // 
            txtViaAmount.Location = new Point(120, 45);
            txtViaAmount.Name = "txtViaAmount";
            txtViaAmount.ReadOnly = true;
            txtViaAmount.Size = new Size(247, 23);
            txtViaAmount.TabIndex = 0;
            txtViaAmount.TextChanged += txtViaAmount_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(161, 53);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 409);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 175);
            panel1.TabIndex = 6;
            panel1.TabStop = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCompute);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(352, 409);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 178);
            panel2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(740, 587);
            Controls.Add(panel2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Sales Computation";
            TopMost = true;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnItem3;
        private Button btnItem2;
        private Button btnItem1;
        private GroupBox groupBox2;
        private TextBox txtDiscount;
        private TextBox txtPrice;
        private GroupBox groupBox3;
        private Button btnCompute;
        private TextBox txtQuality;
        private TextBox txtTotalAmount;
        private TextBox txtVia;
        private TextBox txtViaAmount;
        private Label lbl2;
        private Label lbl1;
        private Label lbl4;
        private Label lbl3;
        private Label lbl7;
        private Label lbl6;
        private Label lbl5;
        private Button btnClear;
        private Panel panel1;
        private Panel panel2;
    }
}
