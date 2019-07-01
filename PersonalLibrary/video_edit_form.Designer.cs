namespace PersonalLibrary
{
    partial class video_edit_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(video_edit_form));
            this.dataGridView_video = new System.Windows.Forms.DataGridView();
            this.txtbox_edit_ti = new System.Windows.Forms.TextBox();
            this.txtbox_edit_md = new System.Windows.Forms.TextBox();
            this.txtbox_edit_aw = new System.Windows.Forms.TextBox();
            this.txtbox_edit_yb = new System.Windows.Forms.TextBox();
            this.txtbox_edit_d = new System.Windows.Forms.TextBox();
            this.lbl_edit_mt = new System.Windows.Forms.Label();
            this.lbl_edit_dn = new System.Windows.Forms.Label();
            this.lbl_edit_year = new System.Windows.Forms.Label();
            this.lbl_edit_aw = new System.Windows.Forms.Label();
            this.lbl_edit_md = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.library_DatabaseDataSet10 = new PersonalLibrary.Library_DatabaseDataSet10();
            this.tBLVideoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLVideoTableAdapter = new PersonalLibrary.Library_DatabaseDataSet10TableAdapters.TBLVideoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videotitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videodirectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoyearofbuildDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videodescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoawardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLVideoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_video
            // 
            this.dataGridView_video.AutoGenerateColumns = false;
            this.dataGridView_video.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_video.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.videotitleDataGridViewTextBoxColumn,
            this.videodirectorDataGridViewTextBoxColumn,
            this.videoyearofbuildDataGridViewTextBoxColumn,
            this.videodescriptionDataGridViewTextBoxColumn,
            this.videoawardsDataGridViewTextBoxColumn});
            this.dataGridView_video.DataSource = this.tBLVideoBindingSource;
            this.dataGridView_video.Location = new System.Drawing.Point(24, 12);
            this.dataGridView_video.MultiSelect = false;
            this.dataGridView_video.Name = "dataGridView_video";
            this.dataGridView_video.RowTemplate.Height = 24;
            this.dataGridView_video.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_video.Size = new System.Drawing.Size(512, 477);
            this.dataGridView_video.TabIndex = 0;
            this.dataGridView_video.SelectionChanged += new System.EventHandler(this.dataGridView_video_SelectionChanged);
            // 
            // txtbox_edit_ti
            // 
            this.txtbox_edit_ti.Location = new System.Drawing.Point(580, 27);
            this.txtbox_edit_ti.Name = "txtbox_edit_ti";
            this.txtbox_edit_ti.Size = new System.Drawing.Size(289, 22);
            this.txtbox_edit_ti.TabIndex = 1;
            // 
            // txtbox_edit_md
            // 
            this.txtbox_edit_md.Location = new System.Drawing.Point(580, 283);
            this.txtbox_edit_md.Multiline = true;
            this.txtbox_edit_md.Name = "txtbox_edit_md";
            this.txtbox_edit_md.Size = new System.Drawing.Size(289, 92);
            this.txtbox_edit_md.TabIndex = 2;
            // 
            // txtbox_edit_aw
            // 
            this.txtbox_edit_aw.Location = new System.Drawing.Point(580, 212);
            this.txtbox_edit_aw.Name = "txtbox_edit_aw";
            this.txtbox_edit_aw.Size = new System.Drawing.Size(289, 22);
            this.txtbox_edit_aw.TabIndex = 3;
            // 
            // txtbox_edit_yb
            // 
            this.txtbox_edit_yb.Location = new System.Drawing.Point(580, 141);
            this.txtbox_edit_yb.Name = "txtbox_edit_yb";
            this.txtbox_edit_yb.Size = new System.Drawing.Size(289, 22);
            this.txtbox_edit_yb.TabIndex = 4;
            // 
            // txtbox_edit_d
            // 
            this.txtbox_edit_d.Location = new System.Drawing.Point(580, 80);
            this.txtbox_edit_d.Name = "txtbox_edit_d";
            this.txtbox_edit_d.Size = new System.Drawing.Size(289, 22);
            this.txtbox_edit_d.TabIndex = 5;
            // 
            // lbl_edit_mt
            // 
            this.lbl_edit_mt.AutoSize = true;
            this.lbl_edit_mt.Location = new System.Drawing.Point(904, 27);
            this.lbl_edit_mt.Name = "lbl_edit_mt";
            this.lbl_edit_mt.Size = new System.Drawing.Size(54, 17);
            this.lbl_edit_mt.TabIndex = 6;
            this.lbl_edit_mt.Text = "عنوان فیلم";
            // 
            // lbl_edit_dn
            // 
            this.lbl_edit_dn.AutoSize = true;
            this.lbl_edit_dn.Location = new System.Drawing.Point(899, 85);
            this.lbl_edit_dn.Name = "lbl_edit_dn";
            this.lbl_edit_dn.Size = new System.Drawing.Size(67, 17);
            this.lbl_edit_dn.TabIndex = 7;
            this.lbl_edit_dn.Text = "نام کارگردان";
            // 
            // lbl_edit_year
            // 
            this.lbl_edit_year.AutoSize = true;
            this.lbl_edit_year.Location = new System.Drawing.Point(899, 146);
            this.lbl_edit_year.Name = "lbl_edit_year";
            this.lbl_edit_year.Size = new System.Drawing.Size(59, 17);
            this.lbl_edit_year.TabIndex = 8;
            this.lbl_edit_year.Text = "سال ساخت";
            // 
            // lbl_edit_aw
            // 
            this.lbl_edit_aw.AutoSize = true;
            this.lbl_edit_aw.Location = new System.Drawing.Point(894, 217);
            this.lbl_edit_aw.Name = "lbl_edit_aw";
            this.lbl_edit_aw.Size = new System.Drawing.Size(72, 17);
            this.lbl_edit_aw.TabIndex = 9;
            this.lbl_edit_aw.Text = "جوایز دریافتی";
            // 
            // lbl_edit_md
            // 
            this.lbl_edit_md.AutoSize = true;
            this.lbl_edit_md.Location = new System.Drawing.Point(904, 286);
            this.lbl_edit_md.Name = "lbl_edit_md";
            this.lbl_edit_md.Size = new System.Drawing.Size(50, 17);
            this.lbl_edit_md.TabIndex = 10;
            this.lbl_edit_md.Text = "شرح فیلم";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(707, 430);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(119, 35);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "ویرایش کردن";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // library_DatabaseDataSet10
            // 
            this.library_DatabaseDataSet10.DataSetName = "Library_DatabaseDataSet10";
            this.library_DatabaseDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLVideoBindingSource
            // 
            this.tBLVideoBindingSource.DataMember = "TBLVideo";
            this.tBLVideoBindingSource.DataSource = this.library_DatabaseDataSet10;
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
            // video_edit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 501);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lbl_edit_md);
            this.Controls.Add(this.lbl_edit_aw);
            this.Controls.Add(this.lbl_edit_year);
            this.Controls.Add(this.lbl_edit_dn);
            this.Controls.Add(this.lbl_edit_mt);
            this.Controls.Add(this.txtbox_edit_d);
            this.Controls.Add(this.txtbox_edit_yb);
            this.Controls.Add(this.txtbox_edit_aw);
            this.Controls.Add(this.txtbox_edit_md);
            this.Controls.Add(this.txtbox_edit_ti);
            this.Controls.Add(this.dataGridView_video);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "video_edit_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ویرایش فیلم";
            this.Load += new System.EventHandler(this.video_edit_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_video)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLVideoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_video;
        private System.Windows.Forms.TextBox txtbox_edit_ti;
        private System.Windows.Forms.TextBox txtbox_edit_md;
        private System.Windows.Forms.TextBox txtbox_edit_aw;
        private System.Windows.Forms.TextBox txtbox_edit_yb;
        private System.Windows.Forms.TextBox txtbox_edit_d;
        private System.Windows.Forms.Label lbl_edit_mt;
        private System.Windows.Forms.Label lbl_edit_dn;
        private System.Windows.Forms.Label lbl_edit_year;
        private System.Windows.Forms.Label lbl_edit_aw;
        private System.Windows.Forms.Label lbl_edit_md;
        private System.Windows.Forms.Button btn_edit;
        private Library_DatabaseDataSet10 library_DatabaseDataSet10;
        private System.Windows.Forms.BindingSource tBLVideoBindingSource;
        private Library_DatabaseDataSet10TableAdapters.TBLVideoTableAdapter tBLVideoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videotitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videodirectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoyearofbuildDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videodescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoawardsDataGridViewTextBoxColumn;
    }
}