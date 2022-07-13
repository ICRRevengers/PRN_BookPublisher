using ConsoleApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class User_ShowBook : Form
    {
        public User_ShowBook()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void User_ShowBook_Load(object sender, EventArgs e)
        {
            BookRepository repo = new BookRepository();
            DataTable data = repo.GetAllBooks();
            dataGridView1.DataSource = data;
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
