namespace PersonalLibrary
{
    partial class book_edit_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book_edit_form));
            this.dataGridView_book = new System.Windows.Forms.DataGridView();
            this.btn_edit_book = new System.Windows.Forms.Button();
            this.lbl_edit_bd = new System.Windows.Forms.Label();
            this.lbl_edit_byear = new System.Windows.Forms.Label();
            this.lbl_edit_ban = new System.Windows.Forms.Label();
            this.lbl_edit_bmt = new System.Windows.Forms.Label();
            this.txtbox_edit_ban = new System.Windows.Forms.TextBox();
            this.txtbox_edit_byp = new System.Windows.Forms.TextBox();
            this.txtbox_edit_bd = new System.Windows.Forms.TextBox();
            this.txtbox_edit_btn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_book
            // 
            this.dataGridView_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_book.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_book.Name = "dataGridView_book";
            this.dataGridView_book.RowTemplate.Height = 24;
            this.dataGridView_book.Size = new System.Drawing.Size(519, 477);
            this.dataGridView_book.TabIndex = 0;
            // 
            // btn_edit_book
            // 
            this.btn_edit_book.Location = new System.Drawing.Point(707, 418);
            this.btn_edit_book.Name = "btn_edit_book";
            this.btn_edit_book.Size = new System.Drawing.Size(119, 35);
            this.btn_edit_book.TabIndex = 22;
            this.btn_edit_book.Text = "ویرایش کردن";
            this.btn_edit_book.UseVisualStyleBackColor = true;
            // 
            // lbl_edit_bd
            // 
            this.lbl_edit_bd.AutoSize = true;
            this.lbl_edit_bd.Location = new System.Drawing.Point(889, 257);
            this.lbl_edit_bd.Name = "lbl_edit_bd";
            this.lbl_edit_bd.Size = new System.Drawing.Size(57, 17);
            this.lbl_edit_bd.TabIndex = 21;
            this.lbl_edit_bd.Text = "شرح کتاب";
            // 
            // lbl_edit_byear
            // 
            this.lbl_edit_byear.AutoSize = true;
            this.lbl_edit_byear.Location = new System.Drawing.Point(884, 146);
            this.lbl_edit_byear.Name = "lbl_edit_byear";
            this.lbl_edit_byear.Size = new System.Drawing.Size(57, 17);
            this.lbl_edit_byear.TabIndex = 19;
            this.lbl_edit_byear.Text = "سال انتشار";
            // 
            // lbl_edit_ban
            // 
            this.lbl_edit_ban.AutoSize = true;
            this.lbl_edit_ban.Location = new System.Drawing.Point(884, 85);
            this.lbl_edit_ban.Name = "lbl_edit_ban";
            this.lbl_edit_ban.Size = new System.Drawing.Size(48, 17);
            this.lbl_edit_ban.TabIndex = 18;
            this.lbl_edit_ban.Text = "نام مولف";
            // 
            // lbl_edit_bmt
            // 
            this.lbl_edit_bmt.AutoSize = true;
            this.lbl_edit_bmt.Location = new System.Drawing.Point(889, 27);
            this.lbl_edit_bmt.Name = "lbl_edit_bmt";
            this.lbl_edit_bmt.Size = new System.Drawing.Size(61, 17);
            this.lbl_edit_bmt.TabIndex = 17;
            this.lbl_edit_bmt.Text = "عنوان کتاب";
            // 
            // txtbox_edit_ban
            // 
            this.txtbox_edit_ban.Location = new System.Drawing.Point(565, 80);
            this.txtbox_edit_ban.Name = "txtbox_edit_ban";
            this.txtbox_edit_ban.Size = new System.Drawing.Size(289, 22);
            this.txtbox_edit_ban.TabIndex = 16;
            // 
            // txtbox_edit_byp
            // 
            this.txtbox_edit_byp.Location = new System.Drawing.Point(565, 141);
            this.txtbox_edit_byp.Name = "txtbox_edit_byp";
            this.txtbox_edit_byp.Size = new System.Drawing.Size(289, 22);
            this.txtbox_edit_byp.TabIndex = 15;
            // 
            // txtbox_edit_bd
            // 
            this.txtbox_edit_bd.Location = new System.Drawing.Point(565, 228);
            this.txtbox_edit_bd.Multiline = true;
            this.txtbox_edit_bd.Name = "txtbox_edit_bd";
            this.txtbox_edit_bd.Size = new System.Drawing.Size(289, 92);
            this.txtbox_edit_bd.TabIndex = 13;
            // 
            // txtbox_edit_btn
            // 
            this.txtbox_edit_btn.Location = new System.Drawing.Point(565, 27);
            this.txtbox_edit_btn.Name = "txtbox_edit_btn";
            this.txtbox_edit_btn.Size = new System.Drawing.Size(289, 22);
            this.txtbox_edit_btn.TabIndex = 12;
            // 
            // book_edit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 501);
            this.Controls.Add(this.btn_edit_book);
            this.Controls.Add(this.lbl_edit_bd);
            this.Controls.Add(this.lbl_edit_byear);
            this.Controls.Add(this.lbl_edit_ban);
            this.Controls.Add(this.lbl_edit_bmt);
            this.Controls.Add(this.txtbox_edit_ban);
            this.Controls.Add(this.txtbox_edit_byp);
            this.Controls.Add(this.txtbox_edit_bd);
            this.Controls.Add(this.txtbox_edit_btn);
            this.Controls.Add(this.dataGridView_book);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "book_edit_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ویرایش کتاب";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_book;
        private System.Windows.Forms.Button btn_edit_book;
        private System.Windows.Forms.Label lbl_edit_bd;
        private System.Windows.Forms.Label lbl_edit_byear;
        private System.Windows.Forms.Label lbl_edit_ban;
        private System.Windows.Forms.Label lbl_edit_bmt;
        private System.Windows.Forms.TextBox txtbox_edit_ban;
        private System.Windows.Forms.TextBox txtbox_edit_byp;
        private System.Windows.Forms.TextBox txtbox_edit_bd;
        private System.Windows.Forms.TextBox txtbox_edit_btn;
    }
}