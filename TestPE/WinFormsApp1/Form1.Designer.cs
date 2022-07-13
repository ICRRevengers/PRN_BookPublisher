
namespace WinFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exit = new System.Windows.Forms.Button();
            this.getallbook = new System.Windows.Forms.Button();
            this.deleteBook = new System.Windows.Forms.Button();
            this.updateBook = new System.Windows.Forms.Button();
            this.addBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Store Management";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookName,
            this.quantity,
            this.authorname});
            this.dataGridView1.Location = new System.Drawing.Point(13, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(765, 267);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bookName
            // 
            this.bookName.HeaderText = "Book Name";
            this.bookName.MinimumWidth = 6;
            this.bookName.Name = "bookName";
            this.bookName.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 125;
            // 
            // authorname
            // 
            this.authorname.HeaderText = "Author Name";
            this.authorname.MinimumWidth = 6;
            this.authorname.Name = "authorname";
            this.authorname.Width = 125;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(684, 371);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(94, 29);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // getallbook
            // 
            this.getallbook.Location = new System.Drawing.Point(386, 371);
            this.getallbook.Name = "getallbook";
            this.getallbook.Size = new System.Drawing.Size(94, 29);
            this.getallbook.TabIndex = 0;
            this.getallbook.Text = "Show Book List";
            this.getallbook.UseVisualStyleBackColor = true;
            this.getallbook.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteBook
            // 
            this.deleteBook.Location = new System.Drawing.Point(261, 371);
            this.deleteBook.Name = "deleteBook";
            this.deleteBook.Size = new System.Drawing.Size(106, 29);
            this.deleteBook.TabIndex = 3;
            this.deleteBook.Text = "Delete Book ";
            this.deleteBook.UseVisualStyleBackColor = true;
            this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // updateBook
            // 
            this.updateBook.Location = new System.Drawing.Point(127, 371);
            this.updateBook.Name = "updateBook";
            this.updateBook.Size = new System.Drawing.Size(111, 29);
            this.updateBook.TabIndex = 2;
            this.updateBook.Text = "Update Book";
            this.updateBook.UseVisualStyleBackColor = true;
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(13, 371);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(94, 29);
            this.addBook.TabIndex = 5;
            this.addBook.Text = "Add Book";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.getallbook);
            this.Controls.Add(this.deleteBook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updateBook);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "BookStoreManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button getallbook;
        private System.Windows.Forms.Button deleteBook;
        private System.Windows.Forms.Button updateBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorname;
        private System.Windows.Forms.Button addBook;
    }
}

