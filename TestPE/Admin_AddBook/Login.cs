using Admin_AddBook;
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
using TestPE.Models;

namespace Winform
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            textBoxUserID.Text = textBoxPassword.Text = string.Empty;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserID.Text.Trim().Length == 0)
            {
                MessageBox.Show("User ID is empty");
                return;
            }
            if (textBoxPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Password is empty");
                return;
            }
            if (btnLogin.Text == "Login")
            {
                AccountUser user = new AccountUser();
                AccountUserRepository repo = new AccountUserRepository();
                user = repo.login(textBoxUserID.Text, textBoxPassword.Text);
                if(user == null)
                {
                    MessageBox.Show("Wrong user id or password");
                    return;
                }
                else
                {
                    if(user.UserRole == 1)
                    {
                        this.Hide();
                        MessageBox.Show("Login successfully");
                        Admin_ShowBook form = new Admin_ShowBook();
                        form.ShowDialog();
                        clear();
                    }
                    else
                    {
                        this.Hide();
                        MessageBox.Show("Login successfully");
                       User_ShowBook form = new User_ShowBook();
                        form.ShowDialog();
                        clear();
                    }
                }
            }
        }
    }
}
