namespace Task4
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
            ListBoxResult = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // ListBoxResult
            // 
            ListBoxResult.FormattingEnabled = true;
            ListBoxResult.Location = new Point(281, 81);
            ListBoxResult.Name = "ListBoxResult";
            ListBoxResult.Size = new Size(390, 304);
            ListBoxResult.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(115, 81);
            button1.Name = "button1";
            button1.Size = new Size(136, 35);
            button1.TabIndex = 1;
            button1.Text = "Sort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ListBoxResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListBoxResult;
        private Button button1;
    }
}
