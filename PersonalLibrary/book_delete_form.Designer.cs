namespace PersonalLibrary
{
    partial class book_delete_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book_delete_form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_bookd = new System.Windows.Forms.Button();
            this.library_DatabaseDataSet3 = new PersonalLibrary.Library_DatabaseDataSet3();
            this.tBLbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLbookTableAdapter = new PersonalLibrary.Library_DatabaseDataSet3TableAdapters.TBLbookTableAdapter();
            this.library_DatabaseDataSet4 = new PersonalLibrary.Library_DatabaseDataSet4();
            this.tBLbookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBLbookTableAdapter1 = new PersonalLibrary.Library_DatabaseDataSet4TableAdapters.TBLbookTableAdapter();
            this.library_DatabaseDataSet5 = new PersonalLibrary.Library_DatabaseDataSet5();
            this.tBLbookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tBLbookTableAdapter2 = new PersonalLibrary.Library_DatabaseDataSet5TableAdapters.TBLbookTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookgenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearofpublishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookstatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bookshabakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.library_DatabaseDataSet6 = new PersonalLibrary.Library_DatabaseDataSet6();
            this.tBLbookBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tBLbookTableAdapter3 = new PersonalLibrary.Library_DatabaseDataSet6TableAdapters.TBLbookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLbookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLbookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLbookBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLbookBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.bookauthorDataGridViewTextBoxColumn,
            this.bookgenreDataGridViewTextBoxColumn,
            this.booktitleDataGridViewTextBoxColumn,
            this.bookdescriptionDataGridViewTextBoxColumn,
            this.yearofpublishDataGridViewTextBoxColumn,
            this.bookstatusDataGridViewCheckBoxColumn,
            this.bookshabakDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLbookBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(973, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_bookd
            // 
            this.btn_bookd.Location = new System.Drawing.Point(496, 462);
            this.btn_bookd.Name = "btn_bookd";
            this.btn_bookd.Size = new System.Drawing.Size(102, 27);
            this.btn_bookd.TabIndex = 1;
            this.btn_bookd.Text = "حذف کردن";
            this.btn_bookd.UseVisualStyleBackColor = true;
            this.btn_bookd.Click += new System.EventHandler(this.btn_bookd_Click);
            // 
            // library_DatabaseDataSet3
            // 
            this.library_DatabaseDataSet3.DataSetName = "Library_DatabaseDataSet3";
            this.library_DatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLbookBindingSource
            // 
            this.tBLbookBindingSource.DataMember = "TBLbook";
            this.tBLbookBindingSource.DataSource = this.library_DatabaseDataSet3;
            // 
            // tBLbookTableAdapter
            // 
            this.tBLbookTableAdapter.ClearBeforeFill = true;
            // 
            // library_DatabaseDataSet4
            // 
            this.library_DatabaseDataSet4.DataSetName = "Library_DatabaseDataSet4";
            this.library_DatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLbookBindingSource1
            // 
            this.tBLbookBindingSource1.DataMember = "TBLbook";
            this.tBLbookBindingSource1.DataSource = this.library_DatabaseDataSet4;
            // 
            // tBLbookTableAdapter1
            // 
            this.tBLbookTableAdapter1.ClearBeforeFill = true;
            // 
            // library_DatabaseDataSet5
            // 
            this.library_DatabaseDataSet5.DataSetName = "Library_DatabaseDataSet5";
            this.library_DatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLbookBindingSource2
            // 
            this.tBLbookBindingSource2.DataMember = "TBLbook";
            this.tBLbookBindingSource2.DataSource = this.library_DatabaseDataSet5;
            // 
            // tBLbookTableAdapter2
            // 
            this.tBLbookTableAdapter2.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "شناسه";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // library_DatabaseDataSet6
            // 
            this.library_DatabaseDataSet6.DataSetName = "Library_DatabaseDataSet6";
            this.library_DatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLbookBindingSource3
            // 
            this.tBLbookBindingSource3.DataMember = "TBLbook";
            this.tBLbookBindingSource3.DataSource = this.library_DatabaseDataSet6;
            // 
            // tBLbookTableAdapter3
            // 
            this.tBLbookTableAdapter3.ClearBeforeFill = true;
            // 
            // book_delete_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 501);
            this.Controls.Add(this.btn_bookd);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "book_delete_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "حذف کتاب";
            this.Load += new System.EventHandler(this.book_delete_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLbookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLbookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLbookBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLbookBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_bookd;
        private Library_DatabaseDataSet3 library_DatabaseDataSet3;
        private System.Windows.Forms.BindingSource tBLbookBindingSource;
        private Library_DatabaseDataSet3TableAdapters.TBLbookTableAdapter tBLbookTableAdapter;
        private Library_DatabaseDataSet4 library_DatabaseDataSet4;
        private System.Windows.Forms.BindingSource tBLbookBindingSource1;
        private Library_DatabaseDataSet4TableAdapters.TBLbookTableAdapter tBLbookTableAdapter1;
        private Library_DatabaseDataSet5 library_DatabaseDataSet5;
        private System.Windows.Forms.BindingSource tBLbookBindingSource2;
        private Library_DatabaseDataSet5TableAdapters.TBLbookTableAdapter tBLbookTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookgenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booktitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearofpublishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bookstatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookshabakDataGridViewTextBoxColumn;
        private Library_DatabaseDataSet6 library_DatabaseDataSet6;
        private System.Windows.Forms.BindingSource tBLbookBindingSource3;
        private Library_DatabaseDataSet6TableAdapters.TBLbookTableAdapter tBLbookTableAdapter3;
    }
}