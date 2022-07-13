using ConsoleApplication.Data;
using ConsoleApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform;

namespace Admin_AddBook
{
    public partial class Admin_ShowBook : Form
    {
        public Admin_ShowBook()
        {
            InitializeComponent();
        }
        private void updateBook_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Admin_AddBook form = new Admin_AddBook();
            form.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BookRepository repo = new BookRepository();
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if(MessageBox.Show("Are you sure you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repo.Delete(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    MessageBox.Show("Delete successfully","Message");
                   
                }
            }else
                if(dataGridView1.Columns[e.ColumnIndex].Name == "Update")
            {
                if (MessageBox.Show("Are you sure you want to update?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Book book = new Book(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()), dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                    MessageBox.Show("Update successfully", "Message");
                    repo.Update(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), book);

                }
            }
            repo = new BookRepository();
            DataTable data = repo.GetAllBooks();
            dataGridView1.DataSource = data;
        }


        private void Admin_ShowBook_Load(object sender, EventArgs e)
        {
            BookRepository repo = new BookRepository();
            DataTable data = repo.GetAllBooks();
            dataGridView1.DataSource = data;
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login form = new Login();
                this.Hide();
                form.ShowDialog();
            }
        }
    }
}
