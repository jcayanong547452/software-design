namespace Task5
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
            Button = new Button();
            ListBoxResult = new ListBox();
            ListBoxUnsorted = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Button
            // 
            Button.Location = new Point(36, 125);
            Button.Name = "Button";
            Button.Size = new Size(139, 68);
            Button.TabIndex = 0;
            Button.Text = "BubbleSorted";
            Button.UseVisualStyleBackColor = true;
            Button.Click += btnSort_Click;
            // 
            // ListBoxResult
            // 
            ListBoxResult.FormattingEnabled = true;
            ListBoxResult.Location = new Point(208, 170);
            ListBoxResult.Name = "ListBoxResult";
            ListBoxResult.Size = new Size(439, 199);
            ListBoxResult.TabIndex = 1;
            ListBoxResult.Click += btnSort_Click;
            ListBoxResult.SelectedIndexChanged += ListBoxResult_SelectedIndexChanged;
            // 
            // ListBoxUnsorted
            // 
            ListBoxUnsorted.FormattingEnabled = true;
            ListBoxUnsorted.Location = new Point(208, 41);
            ListBoxUnsorted.Name = "ListBoxUnsorted";
            ListBoxUnsorted.Size = new Size(440, 94);
            ListBoxUnsorted.TabIndex = 2;
            ListBoxUnsorted.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 14);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 3;
            label1.Text = "Unsorted";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 149);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "Sorted";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ListBoxUnsorted);
            Controls.Add(ListBoxResult);
            Controls.Add(Button);
            Name = "Form1";
            Text = "Form1";
            Click += btnSort_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button;
        private ListBox ListBoxResult;
        private ListBox ListBoxUnsorted;
        private Label label1;
        private Label label2;
    }
}
