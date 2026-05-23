namespace lab5
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
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            btnAddBook = new Button();
            btnShow = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtBookID = new TextBox();
            txtBookTitle = new TextBox();
            txtAuthorOperations = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnUpdate = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            listBox1 = new ListBox();
            groupBox3 = new GroupBox();
            label6 = new Label();
            txtDeleteID = new TextBox();
            btnDelete = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnShow);
            groupBox1.Controls.Add(btnAddBook);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(56, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 183);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ADD BOOKS";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(116, 29);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(146, 30);
            txtAuthor.TabIndex = 1;
            txtAuthor.TextChanged += textBox1_TextChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(116, 85);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(146, 30);
            txtTitle.TabIndex = 2;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBook.Location = new Point(24, 133);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(97, 23);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "+Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click_1;
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(155, 133);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(107, 23);
            btnShow.TabIndex = 4;
            btnShow.Text = "Show/Refresh";
            btnShow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 37);
            label1.Name = "label1";
            label1.Size = new Size(63, 16);
            label1.TabIndex = 5;
            label1.Text = "AUTHOR:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 93);
            label2.Name = "label2";
            label2.Size = new Size(47, 16);
            label2.TabIndex = 6;
            label2.Text = "TITLE:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtAuthorOperations);
            groupBox2.Controls.Add(txtBookTitle);
            groupBox2.Controls.Add(txtBookID);
            groupBox2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(56, 212);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(291, 215);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "BOOK OPERATIONS";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(116, 31);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(146, 26);
            txtBookID.TabIndex = 0;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(116, 79);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(146, 26);
            txtBookTitle.TabIndex = 1;
            // 
            // txtAuthorOperations
            // 
            txtAuthorOperations.Location = new Point(116, 119);
            txtAuthorOperations.Name = "txtAuthorOperations";
            txtAuthorOperations.Size = new Size(146, 26);
            txtAuthorOperations.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 37);
            label3.Name = "label3";
            label3.Size = new Size(62, 16);
            label3.TabIndex = 3;
            label3.Text = "Book ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 85);
            label4.Name = "label4";
            label4.Size = new Size(85, 16);
            label4.TabIndex = 4;
            label4.Text = "Book Title:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 129);
            label5.Name = "label5";
            label5.Size = new Size(63, 16);
            label5.TabIndex = 5;
            label5.Text = "Author:";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(72, 170);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(651, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(395, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(227, 23);
            txtSearch.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(395, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(352, 199);
            listBox1.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(txtDeleteID);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(395, 288);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(352, 139);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "DELETE BOOKS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 35);
            label6.Name = "label6";
            label6.Size = new Size(74, 18);
            label6.TabIndex = 7;
            label6.Text = "Book ID:";
            // 
            // txtDeleteID
            // 
            txtDeleteID.Location = new Point(121, 29);
            txtDeleteID.Name = "txtDeleteID";
            txtDeleteID.Size = new Size(184, 30);
            txtDeleteID.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(98, 90);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 27);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(listBox1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnShow;
        private Button btnAddBook;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private GroupBox groupBox2;
        private Button btnUpdate;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtAuthorOperations;
        private TextBox txtBookTitle;
        private TextBox txtBookID;
        private Button btnSearch;
        private TextBox txtSearch;
        private ListBox listBox1;
        private GroupBox groupBox3;
        private Label label6;
        private Button btnDelete;
        private TextBox txtDeleteID;
    }
}
