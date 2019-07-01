namespace PersonalLibrary
{
    partial class video_find_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(video_find_form));
            this.lbl_find_movie = new System.Windows.Forms.Label();
            this.textBox_find_movie = new System.Windows.Forms.TextBox();
            this.btn_movie_find = new System.Windows.Forms.Button();
            this.dataGridView_movie_find = new System.Windows.Forms.DataGridView();
            this.library_DatabaseDataSet11 = new PersonalLibrary.Library_DatabaseDataSet11();
            this.tBLVideoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLVideoTableAdapter = new PersonalLibrary.Library_DatabaseDataSet11TableAdapters.TBLVideoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videotitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videogenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videodirectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoyearofbuildDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videodescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoawardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videostatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_movie_find)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLVideoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_find_movie
            // 
            this.lbl_find_movie.AutoSize = true;
            this.lbl_find_movie.Location = new System.Drawing.Point(593, 436);
            this.lbl_find_movie.Name = "lbl_find_movie";
            this.lbl_find_movie.Size = new System.Drawing.Size(38, 17);
            this.lbl_find_movie.TabIndex = 5;
            this.lbl_find_movie.Text = "نام فیلم";
            // 
            // textBox_find_movie
            // 
            this.textBox_find_movie.Location = new System.Drawing.Point(326, 436);
            this.textBox_find_movie.Name = "textBox_find_movie";
            this.textBox_find_movie.Size = new System.Drawing.Size(252, 22);
            this.textBox_find_movie.TabIndex = 4;
            this.textBox_find_movie.TextChanged += new System.EventHandler(this.textBox_find_movie_TextChanged);
            // 
            // btn_movie_find
            // 
            this.btn_movie_find.Location = new System.Drawing.Point(75, 432);
            this.btn_movie_find.Name = "btn_movie_find";
            this.btn_movie_find.Size = new System.Drawing.Size(115, 31);
            this.btn_movie_find.TabIndex = 3;
            this.btn_movie_find.Text = "جستجو کردن";
            this.btn_movie_find.UseVisualStyleBackColor = true;
            // 
            // dataGridView_movie_find
            // 
            this.dataGridView_movie_find.AutoGenerateColumns = false;
            this.dataGridView_movie_find.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_movie_find.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.videotitleDataGridViewTextBoxColumn,
            this.videogenreDataGridViewTextBoxColumn,
            this.videodirectorDataGridViewTextBoxColumn,
            this.videoyearofbuildDataGridViewTextBoxColumn,
            this.videodescriptionDataGridViewTextBoxColumn,
            this.videoawardsDataGridViewTextBoxColumn,
            this.videostatusDataGridViewCheckBoxColumn});
            this.dataGridView_movie_find.DataSource = this.tBLVideoBindingSource;
            this.dataGridView_movie_find.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_movie_find.Name = "dataGridView_movie_find";
            this.dataGridView_movie_find.RowTemplate.Height = 24;
            this.dataGridView_movie_find.Size = new System.Drawing.Size(651, 399);
            this.dataGridView_movie_find.TabIndex = 6;
            // 
            // library_DatabaseDataSet11
            // 
            this.library_DatabaseDataSet11.DataSetName = "Library_DatabaseDataSet11";
            this.library_DatabaseDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLVideoBindingSource
            // 
            this.tBLVideoBindingSource.DataMember = "TBLVideo";
            this.tBLVideoBindingSource.DataSource = this.library_DatabaseDataSet11;
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
            this.videostatusDataGridViewCheckBoxColumn.HeaderText = "video_status";
            this.videostatusDataGridViewCheckBoxColumn.Name = "videostatusDataGridViewCheckBoxColumn";
            // 
            // video_find_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 475);
            this.Controls.Add(this.dataGridView_movie_find);
            this.Controls.Add(this.lbl_find_movie);
            this.Controls.Add(this.textBox_find_movie);
            this.Controls.Add(this.btn_movie_find);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "video_find_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "جستجوی فیلم";
            this.Load += new System.EventHandler(this.video_find_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_movie_find)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLVideoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_find_movie;
        private System.Windows.Forms.TextBox textBox_find_movie;
        private System.Windows.Forms.Button btn_movie_find;
        private System.Windows.Forms.DataGridView dataGridView_movie_find;
        private Library_DatabaseDataSet11 library_DatabaseDataSet11;
        private System.Windows.Forms.BindingSource tBLVideoBindingSource;
        private Library_DatabaseDataSet11TableAdapters.TBLVideoTableAdapter tBLVideoTableAdapter;
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