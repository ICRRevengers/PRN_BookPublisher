
namespace Admin_AddBook
{
    partial class Admin_ShowBook
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
            this.exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BookStoreMangement = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.BookStoreMangement.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(853, 533);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(94, 29);
            this.exit.TabIndex = 11;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.bookName,
            this.quantity,
            this.authorname,
            this.PublisherId,
            this.Update,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(18, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(929, 424);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.bookName.Width = 125;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "Quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 125;
            // 
            // authorname
            // 
            this.authorname.DataPropertyName = "AuthorName";
            this.authorname.HeaderText = "Author Name";
            this.authorname.MinimumWidth = 6;
            this.authorname.Name = "authorname";
            this.authorname.Width = 125;
            // 
            // PublisherId
            // 
            this.PublisherId.DataPropertyName = "PublisherID";
            this.PublisherId.HeaderText = "Publisher ID";
            this.PublisherId.MinimumWidth = 6;
            this.PublisherId.Name = "PublisherId";
            this.PublisherId.Width = 125;
            // 
            // Update
            // 
            this.Update.HeaderText = "";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // BookStoreMangement
            // 
            this.BookStoreMangement.Controls.Add(this.label1);
            this.BookStoreMangement.Location = new System.Drawing.Point(18, 31);
            this.BookStoreMangement.Name = "BookStoreMangement";
            this.BookStoreMangement.Size = new System.Drawing.Size(929, 125);
            this.BookStoreMangement.TabIndex = 7;
            this.BookStoreMangement.TabStop = false;
            this.BookStoreMangement.Text = "Book Store Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Page - Mange Book";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(18, 533);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(94, 29);
            this.btnAddBook.TabIndex = 14;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(720, 533);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(94, 29);
            this.btnlogout.TabIndex = 15;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // Admin_ShowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 574);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BookStoreMangement);
            this.Name = "Admin_ShowBook";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Admin_ShowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.BookStoreMangement.ResumeLayout(false);
            this.BookStoreMangement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox BookStoreMangement;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showData;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherId;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnlogout;
    }
}

