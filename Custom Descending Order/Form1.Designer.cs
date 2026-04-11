namespace Custom_Descending_Order
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
            button1 = new Button();
            ListBoxResult = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(48, 129);
            button1.Name = "button1";
            button1.Size = new Size(204, 79);
            button1.TabIndex = 0;
            button1.Text = "Custome Descending Order";
            button1.UseVisualStyleBackColor = true;
            // 
            // ListBoxResult
            // 
            ListBoxResult.FormattingEnabled = true;
            ListBoxResult.Location = new Point(289, 51);
            ListBoxResult.Name = "ListBoxResult";
            ListBoxResult.Size = new Size(382, 304);
            ListBoxResult.TabIndex = 1;
            ListBoxResult.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListBoxResult);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox ListBoxResult;
    }
}
