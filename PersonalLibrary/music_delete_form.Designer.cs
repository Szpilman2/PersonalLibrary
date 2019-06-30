namespace PersonalLibrary
{
    partial class music_delete_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(music_delete_form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBLMusicBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.library_DatabaseDataSet1 = new PersonalLibrary.Library_DatabaseDataSet1();
            this.btn_md = new System.Windows.Forms.Button();
            this.library_DatabaseDataSet = new PersonalLibrary.Library_DatabaseDataSet();
            this.tBLMusicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLMusicTableAdapter = new PersonalLibrary.Library_DatabaseDataSetTableAdapters.TBLMusicTableAdapter();
            this.tBLMusicTableAdapter1 = new PersonalLibrary.Library_DatabaseDataSet1TableAdapters.TBLMusicTableAdapter();
            this.library_DatabaseDataSet2 = new PersonalLibrary.Library_DatabaseDataSet2();
            this.tBLMusicBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tBLMusicTableAdapter2 = new PersonalLibrary.Library_DatabaseDataSet2TableAdapters.TBLMusicTableAdapter();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musictitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicartistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicgenereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muiscstatusDataGridViewImageColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.musicawardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMusicBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMusicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMusicBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.musictitleDataGridViewTextBoxColumn,
            this.musicartistDataGridViewTextBoxColumn,
            this.albumnameDataGridViewTextBoxColumn,
            this.musicdescriptionDataGridViewTextBoxColumn,
            this.musicgenereDataGridViewTextBoxColumn,
            this.muiscstatusDataGridViewImageColumn,
            this.musicawardsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLMusicBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(973, 413);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tBLMusicBindingSource1
            // 
            this.tBLMusicBindingSource1.DataMember = "TBLMusic";
            this.tBLMusicBindingSource1.DataSource = this.library_DatabaseDataSet1;
            // 
            // library_DatabaseDataSet1
            // 
            this.library_DatabaseDataSet1.DataSetName = "Library_DatabaseDataSet1";
            this.library_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_md
            // 
            this.btn_md.Location = new System.Drawing.Point(476, 444);
            this.btn_md.Name = "btn_md";
            this.btn_md.Size = new System.Drawing.Size(106, 35);
            this.btn_md.TabIndex = 1;
            this.btn_md.Text = "حذف کردن";
            this.btn_md.UseVisualStyleBackColor = true;
            this.btn_md.Click += new System.EventHandler(this.btn_md_Click);
            // 
            // library_DatabaseDataSet
            // 
            this.library_DatabaseDataSet.DataSetName = "Library_DatabaseDataSet";
            this.library_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLMusicBindingSource
            // 
            this.tBLMusicBindingSource.DataMember = "TBLMusic";
            this.tBLMusicBindingSource.DataSource = this.library_DatabaseDataSet;
            // 
            // tBLMusicTableAdapter
            // 
            this.tBLMusicTableAdapter.ClearBeforeFill = true;
            // 
            // tBLMusicTableAdapter1
            // 
            this.tBLMusicTableAdapter1.ClearBeforeFill = true;
            // 
            // library_DatabaseDataSet2
            // 
            this.library_DatabaseDataSet2.DataSetName = "Library_DatabaseDataSet2";
            this.library_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLMusicBindingSource2
            // 
            this.tBLMusicBindingSource2.DataMember = "TBLMusic";
            this.tBLMusicBindingSource2.DataSource = this.library_DatabaseDataSet2;
            // 
            // tBLMusicTableAdapter2
            // 
            this.tBLMusicTableAdapter2.ClearBeforeFill = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Id";
            this.Column2.HeaderText = "شناسه";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // musictitleDataGridViewTextBoxColumn
            // 
            this.musictitleDataGridViewTextBoxColumn.DataPropertyName = "music_title";
            this.musictitleDataGridViewTextBoxColumn.HeaderText = "عنوان موسیقی";
            this.musictitleDataGridViewTextBoxColumn.Name = "musictitleDataGridViewTextBoxColumn";
            this.musictitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musicartistDataGridViewTextBoxColumn
            // 
            this.musicartistDataGridViewTextBoxColumn.DataPropertyName = "music_artist";
            this.musicartistDataGridViewTextBoxColumn.HeaderText = "خواننده موسیقی";
            this.musicartistDataGridViewTextBoxColumn.Name = "musicartistDataGridViewTextBoxColumn";
            this.musicartistDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // albumnameDataGridViewTextBoxColumn
            // 
            this.albumnameDataGridViewTextBoxColumn.DataPropertyName = "album_name";
            this.albumnameDataGridViewTextBoxColumn.HeaderText = "نام آلبوم";
            this.albumnameDataGridViewTextBoxColumn.Name = "albumnameDataGridViewTextBoxColumn";
            this.albumnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musicdescriptionDataGridViewTextBoxColumn
            // 
            this.musicdescriptionDataGridViewTextBoxColumn.DataPropertyName = "music_description";
            this.musicdescriptionDataGridViewTextBoxColumn.HeaderText = "توضیحات موسیقی";
            this.musicdescriptionDataGridViewTextBoxColumn.Name = "musicdescriptionDataGridViewTextBoxColumn";
            this.musicdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musicgenereDataGridViewTextBoxColumn
            // 
            this.musicgenereDataGridViewTextBoxColumn.DataPropertyName = "music_genere";
            this.musicgenereDataGridViewTextBoxColumn.HeaderText = "ژانر موسیقی";
            this.musicgenereDataGridViewTextBoxColumn.Name = "musicgenereDataGridViewTextBoxColumn";
            this.musicgenereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // muiscstatusDataGridViewImageColumn
            // 
            this.muiscstatusDataGridViewImageColumn.DataPropertyName = "muisc_status";
            this.muiscstatusDataGridViewImageColumn.HeaderText = "وضعیت موسیقی";
            this.muiscstatusDataGridViewImageColumn.Name = "muiscstatusDataGridViewImageColumn";
            this.muiscstatusDataGridViewImageColumn.ReadOnly = true;
            this.muiscstatusDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // musicawardsDataGridViewTextBoxColumn
            // 
            this.musicawardsDataGridViewTextBoxColumn.DataPropertyName = "music_awards";
            this.musicawardsDataGridViewTextBoxColumn.HeaderText = "جوایز موسیقی";
            this.musicawardsDataGridViewTextBoxColumn.Name = "musicawardsDataGridViewTextBoxColumn";
            this.musicawardsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // music_delete_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 501);
            this.Controls.Add(this.btn_md);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "music_delete_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "حذف موسیقی";
            this.Load += new System.EventHandler(this.music_delete_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMusicBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMusicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMusicBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_md;
        private Library_DatabaseDataSet library_DatabaseDataSet;
        private System.Windows.Forms.BindingSource tBLMusicBindingSource;
        private Library_DatabaseDataSetTableAdapters.TBLMusicTableAdapter tBLMusicTableAdapter;
        private Library_DatabaseDataSet1 library_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource tBLMusicBindingSource1;
        private Library_DatabaseDataSet1TableAdapters.TBLMusicTableAdapter tBLMusicTableAdapter1;
        private Library_DatabaseDataSet2 library_DatabaseDataSet2;
        private System.Windows.Forms.BindingSource tBLMusicBindingSource2;
        private Library_DatabaseDataSet2TableAdapters.TBLMusicTableAdapter tBLMusicTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn musictitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicartistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicgenereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn muiscstatusDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicawardsDataGridViewTextBoxColumn;
    }
}