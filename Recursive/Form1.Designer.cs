namespace RecursivePower
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
            txtBase = new TextBox();
            txtExponential = new TextBox();
            txtResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCompute = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtBase
            // 
            txtBase.Location = new Point(330, 126);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(136, 23);
            txtBase.TabIndex = 0;
            txtBase.TextChanged += textBox1_TextChanged;
            // 
            // txtExponential
            // 
            txtExponential.Location = new Point(330, 181);
            txtExponential.Name = "txtExponential";
            txtExponential.Size = new Size(136, 23);
            txtExponential.TabIndex = 1;
            txtExponential.TextChanged += textBox2_TextChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(353, 300);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(91, 23);
            txtResult.TabIndex = 2;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 129);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter base (x) :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 184);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 4;
            label2.Text = "Enter Exponential (n):";
            // 
            // btnCompute
            // 
            btnCompute.Location = new Point(353, 236);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(91, 35);
            btnCompute.TabIndex = 5;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 308);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnCompute);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResult);
            Controls.Add(txtExponential);
            Controls.Add(txtBase);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recursive Power Calculation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBase;
        private TextBox txtExponential;
        private TextBox txtResult;
        private Label label1;
        private Label label2;
        private Button btnCompute;
        private Label label3;
    }
}
