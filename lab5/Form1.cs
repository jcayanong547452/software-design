using System.Diagnostics.Eventing.Reader;
using System.Net;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddbook_Click(object sender, EventArgs e)
        {
            using (var db = new BookstoreContext())
            {
                var author = new Author
                {
                    Name = txtAuthor.Text
                };
                db.Author = Add(author);

                var book = new Book
                {
                    txtBookTitle = txtBookTitle.Text,
                    Author = author
                };
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click_1(object sender, EventArgs e)
        {

        }
    }
}
