
namespace Admin_AddBook
{
    partial class Admin_AddBook
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
            this.tbnAddBook = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quantity = new System.Windows.Forms.Label();
            this.textBoxPublisherId = new System.Windows.Forms.TextBox();
            this.publisherId = new System.Windows.Forms.Label();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.authorName = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.bookId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbnAddBook
            // 
            this.tbnAddBook.Location = new System.Drawing.Point(17, 291);
            this.tbnAddBook.Name = "tbnAddBook";
            this.tbnAddBook.Size = new System.Drawing.Size(98, 29);
            this.tbnAddBook.TabIndex = 16;
            this.tbnAddBook.Text = "Add Book";
            this.tbnAddBook.Click += new System.EventHandler(this.tbnAddBook_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(378, 288);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(94, 35);
            this.exit.TabIndex = 15;
            this.exit.Text = "Return";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(18, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 57);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Book";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.tbnAddBook);
            this.panel1.Controls.Add(this.textBoxPublisherId);
            this.panel1.Controls.Add(this.publisherId);
            this.panel1.Controls.Add(this.textBoxAuthorName);
            this.panel1.Controls.Add(this.authorName);
            this.panel1.Controls.Add(this.textBoxQuantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxBookName);
            this.panel1.Controls.Add(this.textBoxBookID);
            this.panel1.Controls.Add(this.bookId);
            this.panel1.Location = new System.Drawing.Point(18, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 353);
            this.panel1.TabIndex = 17;
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(17, 121);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(65, 20);
            this.quantity.TabIndex = 10;
            this.quantity.Text = "Quantity";
            // 
            // textBoxPublisherId
            // 
            this.textBoxPublisherId.Location = new System.Drawing.Point(17, 252);
            this.textBoxPublisherId.Name = "textBoxPublisherId";
            this.textBoxPublisherId.Size = new System.Drawing.Size(455, 27);
            this.textBoxPublisherId.TabIndex = 9;
            // 
            // publisherId
            // 
            this.publisherId.AutoSize = true;
            this.publisherId.Location = new System.Drawing.Point(17, 228);
            this.publisherId.Name = "publisherId";
            this.publisherId.Size = new System.Drawing.Size(244, 20);
            this.publisherId.TabIndex = 8;
            this.publisherId.Text = "Publisher ID (PU####(# is number))";
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Location = new System.Drawing.Point(17, 198);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(455, 27);
            this.textBoxAuthorName.TabIndex = 7;
            // 
            // authorName
            // 
            this.authorName.AutoSize = true;
            this.authorName.Location = new System.Drawing.Point(17, 174);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(98, 20);
            this.authorName.TabIndex = 6;
            this.authorName.Text = "Author Name";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(17, 144);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(455, 27);
            this.textBoxQuantity.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book Name";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(17, 92);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(455, 27);
            this.textBoxBookName.TabIndex = 3;
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.Location = new System.Drawing.Point(17, 39);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(455, 27);
            this.textBoxBookID.TabIndex = 17;
            // 
            // bookId
            // 
            this.bookId.AutoSize = true;
            this.bookId.Location = new System.Drawing.Point(17, 14);
            this.bookId.Name = "bookId";
            this.bookId.Size = new System.Drawing.Size(218, 20);
            this.bookId.TabIndex = 0;
            this.bookId.Text = "Book ID (BK####(# is number))";
            // 
            // Admin_AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_AddBook";
            this.Text = "Admin_AddBook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbnAddBook;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPublisherId;
        private System.Windows.Forms.Label publisherId;
        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.Label authorName;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label bookId;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.TextBox textBoxBookID;
    }
}