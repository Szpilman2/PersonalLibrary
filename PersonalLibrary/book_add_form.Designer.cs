namespace PersonalLibrary
{
    partial class book_add_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book_add_form));
            this.lbl_book_name = new System.Windows.Forms.Label();
            this.txt_book_name = new System.Windows.Forms.TextBox();
            this.txt_book_author = new System.Windows.Forms.TextBox();
            this.lbl_book_author = new System.Windows.Forms.Label();
            this.txt_book_publish_year = new System.Windows.Forms.TextBox();
            this.lbl_publish_year = new System.Windows.Forms.Label();
            this.txt_book_description = new System.Windows.Forms.TextBox();
            this.lbl_book_description = new System.Windows.Forms.Label();
            this.combox_book = new System.Windows.Forms.ComboBox();
            this.lbl_book_category = new System.Windows.Forms.Label();
            this.btn_add_book = new System.Windows.Forms.Button();
            this.radiobtn_is_read = new System.Windows.Forms.RadioButton();
            this.radiobtn_isnot_read = new System.Windows.Forms.RadioButton();
            this.lbl_is_read = new System.Windows.Forms.Label();
            this.radiobtn_half_read = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_book_name
            // 
            this.lbl_book_name.AutoSize = true;
            this.lbl_book_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_name.Location = new System.Drawing.Point(29, 33);
            this.lbl_book_name.Name = "lbl_book_name";
            this.lbl_book_name.Size = new System.Drawing.Size(98, 21);
            this.lbl_book_name.TabIndex = 0;
            this.lbl_book_name.Text = "عنوان کتاب :";
            // 
            // txt_book_name
            // 
            this.txt_book_name.Location = new System.Drawing.Point(133, 34);
            this.txt_book_name.Name = "txt_book_name";
            this.txt_book_name.Size = new System.Drawing.Size(156, 22);
            this.txt_book_name.TabIndex = 1;
            this.txt_book_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_book_author
            // 
            this.txt_book_author.Location = new System.Drawing.Point(133, 82);
            this.txt_book_author.Name = "txt_book_author";
            this.txt_book_author.Size = new System.Drawing.Size(156, 22);
            this.txt_book_author.TabIndex = 3;
            this.txt_book_author.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_book_author
            // 
            this.lbl_book_author.AutoSize = true;
            this.lbl_book_author.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_author.Location = new System.Drawing.Point(29, 81);
            this.lbl_book_author.Name = "lbl_book_author";
            this.lbl_book_author.Size = new System.Drawing.Size(96, 21);
            this.lbl_book_author.TabIndex = 2;
            this.lbl_book_author.Text = "مولف کتاب :";
            // 
            // txt_book_publish_year
            // 
            this.txt_book_publish_year.Location = new System.Drawing.Point(133, 131);
            this.txt_book_publish_year.Name = "txt_book_publish_year";
            this.txt_book_publish_year.Size = new System.Drawing.Size(156, 22);
            this.txt_book_publish_year.TabIndex = 5;
            this.txt_book_publish_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_publish_year
            // 
            this.lbl_publish_year.AutoSize = true;
            this.lbl_publish_year.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_publish_year.Location = new System.Drawing.Point(29, 130);
            this.lbl_publish_year.Name = "lbl_publish_year";
            this.lbl_publish_year.Size = new System.Drawing.Size(89, 21);
            this.lbl_publish_year.TabIndex = 4;
            this.lbl_publish_year.Text = "سال نشر :";
            // 
            // txt_book_description
            // 
            this.txt_book_description.Location = new System.Drawing.Point(131, 182);
            this.txt_book_description.Multiline = true;
            this.txt_book_description.Name = "txt_book_description";
            this.txt_book_description.Size = new System.Drawing.Size(156, 71);
            this.txt_book_description.TabIndex = 7;
            this.txt_book_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_book_description
            // 
            this.lbl_book_description.AutoSize = true;
            this.lbl_book_description.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_description.Location = new System.Drawing.Point(27, 181);
            this.lbl_book_description.Name = "lbl_book_description";
            this.lbl_book_description.Size = new System.Drawing.Size(88, 21);
            this.lbl_book_description.TabIndex = 6;
            this.lbl_book_description.Text = "شرح کتاب:";
            // 
            // combox_book
            // 
            this.combox_book.FormattingEnabled = true;
            this.combox_book.Items.AddRange(new object[] {
            "تاریخی",
            "روان شناسی",
            "علوم اجتماعی",
            "ریاضیات",
            "کامپیوتر",
            "نجوم"});
            this.combox_book.Location = new System.Drawing.Point(506, 34);
            this.combox_book.Name = "combox_book";
            this.combox_book.Size = new System.Drawing.Size(140, 24);
            this.combox_book.TabIndex = 8;
            // 
            // lbl_book_category
            // 
            this.lbl_book_category.AutoSize = true;
            this.lbl_book_category.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_category.Location = new System.Drawing.Point(360, 37);
            this.lbl_book_category.Name = "lbl_book_category";
            this.lbl_book_category.Size = new System.Drawing.Size(135, 21);
            this.lbl_book_category.TabIndex = 9;
            this.lbl_book_category.Text = "دسته بندی کتاب:";
            // 
            // btn_add_book
            // 
            this.btn_add_book.Location = new System.Drawing.Point(299, 389);
            this.btn_add_book.Name = "btn_add_book";
            this.btn_add_book.Size = new System.Drawing.Size(98, 36);
            this.btn_add_book.TabIndex = 10;
            this.btn_add_book.Text = "افزودن کتاب";
            this.btn_add_book.UseVisualStyleBackColor = true;
            this.btn_add_book.Click += new System.EventHandler(this.btn_add_book_Click);
            // 
            // radiobtn_is_read
            // 
            this.radiobtn_is_read.AutoSize = true;
            this.radiobtn_is_read.Checked = true;
            this.radiobtn_is_read.Location = new System.Drawing.Point(533, 85);
            this.radiobtn_is_read.Name = "radiobtn_is_read";
            this.radiobtn_is_read.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobtn_is_read.Size = new System.Drawing.Size(79, 21);
            this.radiobtn_is_read.TabIndex = 11;
            this.radiobtn_is_read.TabStop = true;
            this.radiobtn_is_read.Text = "خوانده شده";
            this.radiobtn_is_read.UseVisualStyleBackColor = true;
            this.radiobtn_is_read.CheckedChanged += new System.EventHandler(this.radiobtn_is_read_CheckedChanged);
            // 
            // radiobtn_isnot_read
            // 
            this.radiobtn_isnot_read.AutoSize = true;
            this.radiobtn_isnot_read.Location = new System.Drawing.Point(533, 112);
            this.radiobtn_isnot_read.Name = "radiobtn_isnot_read";
            this.radiobtn_isnot_read.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobtn_isnot_read.Size = new System.Drawing.Size(82, 21);
            this.radiobtn_isnot_read.TabIndex = 12;
            this.radiobtn_isnot_read.Text = "خوانده نشده";
            this.radiobtn_isnot_read.UseVisualStyleBackColor = true;
            // 
            // lbl_is_read
            // 
            this.lbl_is_read.AutoSize = true;
            this.lbl_is_read.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_is_read.Location = new System.Drawing.Point(360, 83);
            this.lbl_is_read.Name = "lbl_is_read";
            this.lbl_is_read.Size = new System.Drawing.Size(157, 21);
            this.lbl_is_read.TabIndex = 13;
            this.lbl_is_read.Text = "وضعیت خواندن کتاب:";
            // 
            // radiobtn_half_read
            // 
            this.radiobtn_half_read.AutoSize = true;
            this.radiobtn_half_read.Location = new System.Drawing.Point(533, 139);
            this.radiobtn_half_read.Name = "radiobtn_half_read";
            this.radiobtn_half_read.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobtn_half_read.Size = new System.Drawing.Size(111, 21);
            this.radiobtn_half_read.TabIndex = 14;
            this.radiobtn_half_read.Text = "قسمتی خوانده شده\r\n";
            this.radiobtn_half_read.UseVisualStyleBackColor = true;
            // 
            // book_add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 475);
            this.Controls.Add(this.radiobtn_half_read);
            this.Controls.Add(this.lbl_is_read);
            this.Controls.Add(this.radiobtn_isnot_read);
            this.Controls.Add(this.radiobtn_is_read);
            this.Controls.Add(this.btn_add_book);
            this.Controls.Add(this.lbl_book_category);
            this.Controls.Add(this.combox_book);
            this.Controls.Add(this.txt_book_description);
            this.Controls.Add(this.lbl_book_description);
            this.Controls.Add(this.txt_book_publish_year);
            this.Controls.Add(this.lbl_publish_year);
            this.Controls.Add(this.txt_book_author);
            this.Controls.Add(this.lbl_book_author);
            this.Controls.Add(this.txt_book_name);
            this.Controls.Add(this.lbl_book_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "book_add_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "افزودن کتاب";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_book_name;
        private System.Windows.Forms.TextBox txt_book_name;
        private System.Windows.Forms.TextBox txt_book_author;
        private System.Windows.Forms.Label lbl_book_author;
        private System.Windows.Forms.TextBox txt_book_publish_year;
        private System.Windows.Forms.Label lbl_publish_year;
        private System.Windows.Forms.TextBox txt_book_description;
        private System.Windows.Forms.Label lbl_book_description;
        private System.Windows.Forms.ComboBox combox_book;
        private System.Windows.Forms.Label lbl_book_category;
        private System.Windows.Forms.Button btn_add_book;
        private System.Windows.Forms.RadioButton radiobtn_is_read;
        private System.Windows.Forms.RadioButton radiobtn_isnot_read;
        private System.Windows.Forms.Label lbl_is_read;
        private System.Windows.Forms.RadioButton radiobtn_half_read;
    }
}