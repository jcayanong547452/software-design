namespace RecursiveFibonnaciSequence
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
            txtEnter = new TextBox();
            btnCompute = new Button();
            label1 = new Label();
            label2 = new Label();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // txtEnter
            // 
            txtEnter.Location = new Point(336, 156);
            txtEnter.Name = "txtEnter";
            txtEnter.Size = new Size(120, 23);
            txtEnter.TabIndex = 0;
            txtEnter.TextChanged += txtEnter_TextChanged;
            // 
            // btnCompute
            // 
            btnCompute.Location = new Point(256, 200);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(84, 42);
            btnCompute.TabIndex = 1;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 164);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter n:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 219);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Result:";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(411, 211);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 4;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCompute);
            Controls.Add(txtEnter);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recursive Fibonacci Sequence";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEnter;
        private Button btnCompute;
        private Label label1;
        private Label label2;
        private TextBox txtResult;
    }
}
