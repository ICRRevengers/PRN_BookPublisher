
namespace Winform
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.Title_Login = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(63, 124);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(290, 27);
            this.textBoxUserID.TabIndex = 0;
            // 
            // Title_Login
            // 
            this.Title_Login.AutoSize = true;
            this.Title_Login.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title_Login.Location = new System.Drawing.Point(174, 9);
            this.Title_Login.Name = "Title_Login";
            this.Title_Login.Size = new System.Drawing.Size(103, 46);
            this.Title_Login.TabIndex = 1;
            this.Title_Login.Text = "Login";
            // 
            // userID
            // 
            this.userID.AutoSize = true;
            this.userID.Location = new System.Drawing.Point(63, 101);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(57, 20);
            this.userID.TabIndex = 3;
            this.userID.Text = "User ID";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(63, 174);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(70, 20);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(63, 198);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(290, 27);
            this.textBoxPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(63, 259);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(290, 106);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.Title_Login);
            this.Controls.Add(this.textBoxUserID);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label Title_Login;
        private System.Windows.Forms.Label userID;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}