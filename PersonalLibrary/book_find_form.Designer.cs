namespace PersonalLibrary
{
    partial class book_find_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book_find_form));
            this.btn_bfind = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_findb = new System.Windows.Forms.Label();
            this.dataGridView_book_find = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book_find)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bfind
            // 
            this.btn_bfind.Location = new System.Drawing.Point(83, 429);
            this.btn_bfind.Name = "btn_bfind";
            this.btn_bfind.Size = new System.Drawing.Size(115, 31);
            this.btn_bfind.TabIndex = 0;
            this.btn_bfind.Text = "جستجو کردن";
            this.btn_bfind.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(334, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lbl_findb
            // 
            this.lbl_findb.AutoSize = true;
            this.lbl_findb.Location = new System.Drawing.Point(601, 433);
            this.lbl_findb.Name = "lbl_findb";
            this.lbl_findb.Size = new System.Drawing.Size(45, 17);
            this.lbl_findb.TabIndex = 2;
            this.lbl_findb.Text = "نام کتاب";
            // 
            // dataGridView_book_find
            // 
            this.dataGridView_book_find.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_book_find.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_book_find.Name = "dataGridView_book_find";
            this.dataGridView_book_find.RowTemplate.Height = 24;
            this.dataGridView_book_find.Size = new System.Drawing.Size(651, 401);
            this.dataGridView_book_find.TabIndex = 3;
            // 
            // book_find_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 475);
            this.Controls.Add(this.dataGridView_book_find);
            this.Controls.Add(this.lbl_findb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_bfind);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "book_find_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "جستجوی کتاب";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book_find)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bfind;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_findb;
        private System.Windows.Forms.DataGridView dataGridView_book_find;
    }
}