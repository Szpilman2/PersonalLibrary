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
            this.components = new System.ComponentModel.Container();
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
            this.library_DatabaseDataSet3 = new PersonalLibrary.Library_DatabaseDataSet3();
            this.libraryDatabaseDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_DatabaseDataSet6 = new PersonalLibrary.Library_DatabaseDataSet6();
            this.libraryDatabaseDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_DatabaseDataSet7 = new PersonalLibrary.Library_DatabaseDataSet7();
            this.tBLbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLbookTableAdapter = new PersonalLibrary.Library_DatabaseDataSet7TableAdapters.TBLbookTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearofpublishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLbookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_book
            // 
            this.dataGridView_book.AllowUserToAddRows = false;
            this.dataGridView_book.AllowUserToDeleteRows = false;
            this.dataGridView_book.AutoGenerateColumns = false;
            this.dataGridView_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bookauthorDataGridViewTextBoxColumn,
            this.booktitleDataGridViewTextBoxColumn,
            this.bookdescriptionDataGridViewTextBoxColumn,
            this.yearofpublishDataGridViewTextBoxColumn});
            this.dataGridView_book.DataSource = this.tBLbookBindingSource;
            this.dataGridView_book.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_book.MultiSelect = false;
            this.dataGridView_book.Name = "dataGridView_book";
            this.dataGridView_book.ReadOnly = true;
            this.dataGridView_book.RowTemplate.Height = 24;
            this.dataGridView_book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_book.Size = new System.Drawing.Size(519, 477);
            this.dataGridView_book.TabIndex = 0;
            this.dataGridView_book.SelectionChanged += new System.EventHandler(this.dataGridView_OnSelectionChanged);
            // 
            // btn_edit_book
            // 
            this.btn_edit_book.Location = new System.Drawing.Point(707, 418);
            this.btn_edit_book.Name = "btn_edit_book";
            this.btn_edit_book.Size = new System.Drawing.Size(119, 35);
            this.btn_edit_book.TabIndex = 22;
            this.btn_edit_book.Text = "ویرایش کردن";
            this.btn_edit_book.UseVisualStyleBackColor = true;
            this.btn_edit_book.Click += new System.EventHandler(this.btn_edit_book_Click);
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
            // library_DatabaseDataSet3
            // 
            this.library_DatabaseDataSet3.DataSetName = "Library_DatabaseDataSet3";
            this.library_DatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryDatabaseDataSet3BindingSource
            // 
            this.libraryDatabaseDataSet3BindingSource.DataSource = this.library_DatabaseDataSet3;
            this.libraryDatabaseDataSet3BindingSource.Position = 0;
            // 
            // library_DatabaseDataSet6
            // 
            this.library_DatabaseDataSet6.DataSetName = "Library_DatabaseDataSet6";
            this.library_DatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryDatabaseDataSet6BindingSource
            // 
            this.libraryDatabaseDataSet6BindingSource.DataSource = this.library_DatabaseDataSet6;
            this.libraryDatabaseDataSet6BindingSource.Position = 0;
            // 
            // library_DatabaseDataSet7
            // 
            this.library_DatabaseDataSet7.DataSetName = "Library_DatabaseDataSet7";
            this.library_DatabaseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLbookBindingSource
            // 
            this.tBLbookBindingSource.DataMember = "TBLbook";
            this.tBLbookBindingSource.DataSource = this.library_DatabaseDataSet7;
            // 
            // tBLbookTableAdapter
            // 
            this.tBLbookTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookauthorDataGridViewTextBoxColumn
            // 
            this.bookauthorDataGridViewTextBoxColumn.DataPropertyName = "book_author";
            this.bookauthorDataGridViewTextBoxColumn.HeaderText = "book_author";
            this.bookauthorDataGridViewTextBoxColumn.Name = "bookauthorDataGridViewTextBoxColumn";
            this.bookauthorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // booktitleDataGridViewTextBoxColumn
            // 
            this.booktitleDataGridViewTextBoxColumn.DataPropertyName = "book_title";
            this.booktitleDataGridViewTextBoxColumn.HeaderText = "book_title";
            this.booktitleDataGridViewTextBoxColumn.Name = "booktitleDataGridViewTextBoxColumn";
            this.booktitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookdescriptionDataGridViewTextBoxColumn
            // 
            this.bookdescriptionDataGridViewTextBoxColumn.DataPropertyName = "book_description";
            this.bookdescriptionDataGridViewTextBoxColumn.HeaderText = "book_description";
            this.bookdescriptionDataGridViewTextBoxColumn.Name = "bookdescriptionDataGridViewTextBoxColumn";
            this.bookdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearofpublishDataGridViewTextBoxColumn
            // 
            this.yearofpublishDataGridViewTextBoxColumn.DataPropertyName = "year_of_publish";
            this.yearofpublishDataGridViewTextBoxColumn.HeaderText = "year_of_publish";
            this.yearofpublishDataGridViewTextBoxColumn.Name = "yearofpublishDataGridViewTextBoxColumn";
            this.yearofpublishDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.Load += new System.EventHandler(this.book_edit_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLbookBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource libraryDatabaseDataSet3BindingSource;
        private Library_DatabaseDataSet3 library_DatabaseDataSet3;
        private System.Windows.Forms.BindingSource libraryDatabaseDataSet6BindingSource;
        private Library_DatabaseDataSet6 library_DatabaseDataSet6;
        private Library_DatabaseDataSet7 library_DatabaseDataSet7;
        private System.Windows.Forms.BindingSource tBLbookBindingSource;
        private Library_DatabaseDataSet7TableAdapters.TBLbookTableAdapter tBLbookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booktitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearofpublishDataGridViewTextBoxColumn;
    }
}