namespace PersonalLibrary
{
    partial class video_delete_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(video_delete_form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_bd = new System.Windows.Forms.Button();
            this.library_DatabaseDataSet13 = new PersonalLibrary.Library_DatabaseDataSet13();
            this.tBLVideoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLVideoTableAdapter = new PersonalLibrary.Library_DatabaseDataSet13TableAdapters.TBLVideoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videotitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videogenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videodirectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoyearofbuildDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videodescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoawardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videostatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLVideoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.videotitleDataGridViewTextBoxColumn,
            this.videogenreDataGridViewTextBoxColumn,
            this.videodirectorDataGridViewTextBoxColumn,
            this.videoyearofbuildDataGridViewTextBoxColumn,
            this.videodescriptionDataGridViewTextBoxColumn,
            this.videoawardsDataGridViewTextBoxColumn,
            this.videostatusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLVideoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(973, 424);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_bd
            // 
            this.btn_bd.Location = new System.Drawing.Point(482, 460);
            this.btn_bd.Name = "btn_bd";
            this.btn_bd.Size = new System.Drawing.Size(87, 29);
            this.btn_bd.TabIndex = 1;
            this.btn_bd.Text = "حذف کردن";
            this.btn_bd.UseVisualStyleBackColor = true;
            this.btn_bd.Click += new System.EventHandler(this.btn_bd_Click);
            // 
            // library_DatabaseDataSet13
            // 
            this.library_DatabaseDataSet13.DataSetName = "Library_DatabaseDataSet13";
            this.library_DatabaseDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLVideoBindingSource
            // 
            this.tBLVideoBindingSource.DataMember = "TBLVideo";
            this.tBLVideoBindingSource.DataSource = this.library_DatabaseDataSet13;
            // 
            // tBLVideoTableAdapter
            // 
            this.tBLVideoTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // videotitleDataGridViewTextBoxColumn
            // 
            this.videotitleDataGridViewTextBoxColumn.DataPropertyName = "video_title";
            this.videotitleDataGridViewTextBoxColumn.HeaderText = "عنوان فیلم";
            this.videotitleDataGridViewTextBoxColumn.Name = "videotitleDataGridViewTextBoxColumn";
            // 
            // videogenreDataGridViewTextBoxColumn
            // 
            this.videogenreDataGridViewTextBoxColumn.DataPropertyName = "video_genre";
            this.videogenreDataGridViewTextBoxColumn.HeaderText = "ژانر فیلم";
            this.videogenreDataGridViewTextBoxColumn.Name = "videogenreDataGridViewTextBoxColumn";
            // 
            // videodirectorDataGridViewTextBoxColumn
            // 
            this.videodirectorDataGridViewTextBoxColumn.DataPropertyName = "video_director";
            this.videodirectorDataGridViewTextBoxColumn.HeaderText = "نام کارگردان";
            this.videodirectorDataGridViewTextBoxColumn.Name = "videodirectorDataGridViewTextBoxColumn";
            // 
            // videoyearofbuildDataGridViewTextBoxColumn
            // 
            this.videoyearofbuildDataGridViewTextBoxColumn.DataPropertyName = "video_year_of_build";
            this.videoyearofbuildDataGridViewTextBoxColumn.HeaderText = "سال ساخت";
            this.videoyearofbuildDataGridViewTextBoxColumn.Name = "videoyearofbuildDataGridViewTextBoxColumn";
            // 
            // videodescriptionDataGridViewTextBoxColumn
            // 
            this.videodescriptionDataGridViewTextBoxColumn.DataPropertyName = "video_description";
            this.videodescriptionDataGridViewTextBoxColumn.HeaderText = "شرح فیلم";
            this.videodescriptionDataGridViewTextBoxColumn.Name = "videodescriptionDataGridViewTextBoxColumn";
            // 
            // videoawardsDataGridViewTextBoxColumn
            // 
            this.videoawardsDataGridViewTextBoxColumn.DataPropertyName = "video_awards";
            this.videoawardsDataGridViewTextBoxColumn.HeaderText = "جوایز دریافتی";
            this.videoawardsDataGridViewTextBoxColumn.Name = "videoawardsDataGridViewTextBoxColumn";
            // 
            // videostatusDataGridViewCheckBoxColumn
            // 
            this.videostatusDataGridViewCheckBoxColumn.DataPropertyName = "video_status";
            this.videostatusDataGridViewCheckBoxColumn.HeaderText = "وضعیت مشاهده";
            this.videostatusDataGridViewCheckBoxColumn.Name = "videostatusDataGridViewCheckBoxColumn";
            // 
            // video_delete_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 501);
            this.Controls.Add(this.btn_bd);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "video_delete_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "حذف فیلم";
            this.Load += new System.EventHandler(this.video_delete_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLVideoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_bd;
        private Library_DatabaseDataSet13 library_DatabaseDataSet13;
        private System.Windows.Forms.BindingSource tBLVideoBindingSource;
        private Library_DatabaseDataSet13TableAdapters.TBLVideoTableAdapter tBLVideoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videotitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videogenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videodirectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoyearofbuildDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videodescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoawardsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn videostatusDataGridViewCheckBoxColumn;
    }
}