
namespace Winform
{
    partial class User_ShowBook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookStore = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.BookStore.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.bookName,
            this.quantity,
            this.authorname,
            this.PublisherId});
            this.dataGridView1.Location = new System.Drawing.Point(18, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(682, 267);
            this.dataGridView1.TabIndex = 10;
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "BookID";
            this.BookId.HeaderText = "Book ID";
            this.BookId.MinimumWidth = 6;
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Width = 125;
            // 
            // bookName
            // 
            this.bookName.DataPropertyName = "BookName";
            this.bookName.HeaderText = "Book Name";
            this.bookName.MinimumWidth = 6;
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            this.bookName.Width = 125;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "Quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 125;
            // 
            // authorname
            // 
            this.authorname.DataPropertyName = "AuthorName";
            this.authorname.HeaderText = "Author Name";
            this.authorname.MinimumWidth = 6;
            this.authorname.Name = "authorname";
            this.authorname.ReadOnly = true;
            this.authorname.Width = 125;
            // 
            // PublisherId
            // 
            this.PublisherId.DataPropertyName = "PublisherID";
            this.PublisherId.HeaderText = "Publisher ID";
            this.PublisherId.MinimumWidth = 6;
            this.PublisherId.Name = "PublisherId";
            this.PublisherId.ReadOnly = true;
            this.PublisherId.Width = 125;
            // 
            // BookStore
            // 
            this.BookStore.Controls.Add(this.label1);
            this.BookStore.Location = new System.Drawing.Point(18, 56);
            this.BookStore.Name = "BookStore";
            this.BookStore.Size = new System.Drawing.Size(682, 125);
            this.BookStore.TabIndex = 9;
            this.BookStore.TabStop = false;
            this.BookStore.Text = "Book Store ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Page - Book";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(581, 409);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(94, 29);
            this.exit.TabIndex = 12;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(443, 409);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(94, 29);
            this.btnlogout.TabIndex = 13;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // User_ShowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BookStore);
            this.Name = "User_ShowBook";
            this.Text = "User_ShowBook";
            this.Load += new System.EventHandler(this.User_ShowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.BookStore.ResumeLayout(false);
            this.BookStore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox BookStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherId;
    }
}