using ConsoleApplication.Data;
using ConsoleApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_AddBook
{
    public partial class Admin_AddBook : Form
    {
        public Admin_AddBook()
        {
            InitializeComponent();
        }
        public void clear()
        {
            textBoxBookID.Text = textBoxBookName.Text = textBoxQuantity.Text = textBoxAuthorName.Text = textBoxPublisherId.Text = string.Empty;
        }
        private void tbnAddBook_Click(object sender, EventArgs e)
        {
            if(textBoxBookID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Book ID is empty");
                    return;
            }
            if(textBoxBookName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Book Name is empty");
                return;
            }
            if (textBoxQuantity.Text.Trim().Length == 0)
            {
                MessageBox.Show("Book Quantity is empty");
                return;
            }
            if (int.Parse(textBoxQuantity.Text) < 0)
            {
                MessageBox.Show("Book Quantity must not be minus");
                return;
            }
            if (textBoxAuthorName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Author Name is empty");
                return;
            }
            if (textBoxPublisherId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Publisher Id is empty");
                return;
            }
            if (!Regex.Match(textBoxBookID.Text.Trim(), "BK[0-9]{4}").Success)
            {
                MessageBox.Show("Book ID is not format correctly");
                return;
            }
            if (!Regex.Match(textBoxPublisherId.Text.Trim(), "PU[0-9]{4}").Success)
            {
                MessageBox.Show("Publisher ID is not format correctly");
                return;
            }
            if (tbnAddBook.Text == "Add Book")
            {
                if (MessageBox.Show("Are you sure you want to Add?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BookRepository repo = new BookRepository();
                    Book book = new Book(textBoxBookID.Text.Trim(), textBoxBookName.Text.Trim(), int.Parse(textBoxQuantity.Text.Trim()), textBoxAuthorName.Text.Trim(), textBoxPublisherId.Text.Trim());
                    repo.Add(book);
                    MessageBox.Show("Add successfully");
                    clear();
                }
                else
                {
                    MessageBox.Show("Book not added");
                }
                
            }
        }
    }
}
