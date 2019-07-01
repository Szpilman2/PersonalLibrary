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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book_find_form));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_findb = new System.Windows.Forms.Label();
            this.dataGridView_book_find = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookgenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearofpublishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookstatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bookshabakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_DatabaseDataSet8 = new PersonalLibrary.Library_DatabaseDataSet8();
            this.tBLbookTableAdapter = new PersonalLibrary.Library_DatabaseDataSet8TableAdapters.TBLbookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book_find)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLbookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(334, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.dataGridView_book_find.AllowUserToAddRows = false;
            this.dataGridView_book_find.AllowUserToDeleteRows = false;
            this.dataGridView_book_find.AutoGenerateColumns = false;
            this.dataGridView_book_find.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_book_find.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bookauthorDataGridViewTextBoxColumn,
            this.bookgenreDataGridViewTextBoxColumn,
            this.booktitleDataGridViewTextBoxColumn,
            this.bookdescriptionDataGridViewTextBoxColumn,
            this.yearofpublishDataGridViewTextBoxColumn,
            this.bookstatusDataGridViewCheckBoxColumn,
            this.bookshabakDataGridViewTextBoxColumn});
            this.dataGridView_book_find.DataSource = this.tBLbookBindingSource;
            this.dataGridView_book_find.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_book_find.MultiSelect = false;
            this.dataGridView_book_find.Name = "dataGridView_book_find";
            this.dataGridView_book_find.ReadOnly = true;
            this.dataGridView_book_find.RowTemplate.Height = 24;
            this.dataGridView_book_find.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_book_find.Size = new System.Drawing.Size(651, 401);
            this.dataGridView_book_find.TabIndex = 3;
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
            // bookgenreDataGridViewTextBoxColumn
            // 
            this.bookgenreDataGridViewTextBoxColumn.DataPropertyName = "book_genre";
            this.bookgenreDataGridViewTextBoxColumn.HeaderText = "book_genre";
            this.bookgenreDataGridViewTextBoxColumn.Name = "bookgenreDataGridViewTextBoxColumn";
            this.bookgenreDataGridViewTextBoxColumn.ReadOnly = true;
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
            // bookstatusDataGridViewCheckBoxColumn
            // 
            this.bookstatusDataGridViewCheckBoxColumn.DataPropertyName = "book_status";
            this.bookstatusDataGridViewCheckBoxColumn.HeaderText = "book_status";
            this.bookstatusDataGridViewCheckBoxColumn.Name = "bookstatusDataGridViewCheckBoxColumn";
            this.bookstatusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bookshabakDataGridViewTextBoxColumn
            // 
            this.bookshabakDataGridViewTextBoxColumn.DataPropertyName = "book_shabak";
            this.bookshabakDataGridViewTextBoxColumn.HeaderText = "book_shabak";
            this.bookshabakDataGridViewTextBoxColumn.Name = "bookshabakDataGridViewTextBoxColumn";
            this.bookshabakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tBLbookBindingSource
            // 
            this.tBLbookBindingSource.DataMember = "TBLbook";
            this.tBLbookBindingSource.DataSource = this.library_DatabaseDataSet8;
            // 
            // library_DatabaseDataSet8
            // 
            this.library_DatabaseDataSet8.DataSetName = "Library_DatabaseDataSet8";
            this.library_DatabaseDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLbookTableAdapter
            // 
            this.tBLbookTableAdapter.ClearBeforeFill = true;
            // 
            // book_find_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 475);
            this.Controls.Add(this.dataGridView_book_find);
            this.Controls.Add(this.lbl_findb);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "book_find_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "جستجوی کتاب";
            this.Load += new System.EventHandler(this.book_find_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book_find)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLbookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_findb;
        private System.Windows.Forms.DataGridView dataGridView_book_find;
        private Library_DatabaseDataSet8 library_DatabaseDataSet8;
        private System.Windows.Forms.BindingSource tBLbookBindingSource;
        private Library_DatabaseDataSet8TableAdapters.TBLbookTableAdapter tBLbookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookgenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booktitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearofpublishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bookstatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookshabakDataGridViewTextBoxColumn;
    }
}