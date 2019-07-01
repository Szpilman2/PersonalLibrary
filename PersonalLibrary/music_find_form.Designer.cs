namespace PersonalLibrary
{
    partial class music_find_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(music_find_form));
            this.lbl_findmusic = new System.Windows.Forms.Label();
            this.txtbox_find_music = new System.Windows.Forms.TextBox();
            this.btn_mfind = new System.Windows.Forms.Button();
            this.dataGridView_music_find = new System.Windows.Forms.DataGridView();
            this.library_DatabaseDataSet12 = new PersonalLibrary.Library_DatabaseDataSet12();
            this.tBLMusicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLMusicTableAdapter = new PersonalLibrary.Library_DatabaseDataSet12TableAdapters.TBLMusicTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musictitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicartistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicgenereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muiscstatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.musicawardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_music_find)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMusicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_findmusic
            // 
            this.lbl_findmusic.AutoSize = true;
            this.lbl_findmusic.Location = new System.Drawing.Point(587, 436);
            this.lbl_findmusic.Name = "lbl_findmusic";
            this.lbl_findmusic.Size = new System.Drawing.Size(57, 17);
            this.lbl_findmusic.TabIndex = 5;
            this.lbl_findmusic.Text = "نام موسیقی";
            // 
            // txtbox_find_music
            // 
            this.txtbox_find_music.Location = new System.Drawing.Point(320, 436);
            this.txtbox_find_music.Name = "txtbox_find_music";
            this.txtbox_find_music.Size = new System.Drawing.Size(252, 22);
            this.txtbox_find_music.TabIndex = 4;
            this.txtbox_find_music.TextChanged += new System.EventHandler(this.txtbox_find_music_TextChanged);
            // 
            // btn_mfind
            // 
            this.btn_mfind.Location = new System.Drawing.Point(69, 432);
            this.btn_mfind.Name = "btn_mfind";
            this.btn_mfind.Size = new System.Drawing.Size(115, 31);
            this.btn_mfind.TabIndex = 3;
            this.btn_mfind.Text = "جستجو کردن";
            this.btn_mfind.UseVisualStyleBackColor = true;
            // 
            // dataGridView_music_find
            // 
            this.dataGridView_music_find.AutoGenerateColumns = false;
            this.dataGridView_music_find.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_music_find.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.musictitleDataGridViewTextBoxColumn,
            this.musicartistDataGridViewTextBoxColumn,
            this.albumnameDataGridViewTextBoxColumn,
            this.musicdescriptionDataGridViewTextBoxColumn,
            this.musicgenereDataGridViewTextBoxColumn,
            this.muiscstatusDataGridViewCheckBoxColumn,
            this.musicawardsDataGridViewTextBoxColumn});
            this.dataGridView_music_find.DataSource = this.tBLMusicBindingSource;
            this.dataGridView_music_find.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_music_find.Name = "dataGridView_music_find";
            this.dataGridView_music_find.RowTemplate.Height = 24;
            this.dataGridView_music_find.Size = new System.Drawing.Size(651, 400);
            this.dataGridView_music_find.TabIndex = 6;
            // 
            // library_DatabaseDataSet12
            // 
            this.library_DatabaseDataSet12.DataSetName = "Library_DatabaseDataSet12";
            this.library_DatabaseDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLMusicBindingSource
            // 
            this.tBLMusicBindingSource.DataMember = "TBLMusic";
            this.tBLMusicBindingSource.DataSource = this.library_DatabaseDataSet12;
            // 
            // tBLMusicTableAdapter
            // 
            this.tBLMusicTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musictitleDataGridViewTextBoxColumn
            // 
            this.musictitleDataGridViewTextBoxColumn.DataPropertyName = "music_title";
            this.musictitleDataGridViewTextBoxColumn.HeaderText = "عنوان موسیقی";
            this.musictitleDataGridViewTextBoxColumn.Name = "musictitleDataGridViewTextBoxColumn";
            // 
            // musicartistDataGridViewTextBoxColumn
            // 
            this.musicartistDataGridViewTextBoxColumn.DataPropertyName = "music_artist";
            this.musicartistDataGridViewTextBoxColumn.HeaderText = "نام خواننده";
            this.musicartistDataGridViewTextBoxColumn.Name = "musicartistDataGridViewTextBoxColumn";
            // 
            // albumnameDataGridViewTextBoxColumn
            // 
            this.albumnameDataGridViewTextBoxColumn.DataPropertyName = "album_name";
            this.albumnameDataGridViewTextBoxColumn.HeaderText = "نام آلبوم";
            this.albumnameDataGridViewTextBoxColumn.Name = "albumnameDataGridViewTextBoxColumn";
            // 
            // musicdescriptionDataGridViewTextBoxColumn
            // 
            this.musicdescriptionDataGridViewTextBoxColumn.DataPropertyName = "music_description";
            this.musicdescriptionDataGridViewTextBoxColumn.HeaderText = "شرح موسیقی";
            this.musicdescriptionDataGridViewTextBoxColumn.Name = "musicdescriptionDataGridViewTextBoxColumn";
            // 
            // musicgenereDataGridViewTextBoxColumn
            // 
            this.musicgenereDataGridViewTextBoxColumn.DataPropertyName = "music_genere";
            this.musicgenereDataGridViewTextBoxColumn.HeaderText = "ژانر موسیقی";
            this.musicgenereDataGridViewTextBoxColumn.Name = "musicgenereDataGridViewTextBoxColumn";
            // 
            // muiscstatusDataGridViewCheckBoxColumn
            // 
            this.muiscstatusDataGridViewCheckBoxColumn.DataPropertyName = "muisc_status";
            this.muiscstatusDataGridViewCheckBoxColumn.HeaderText = "muisc_status";
            this.muiscstatusDataGridViewCheckBoxColumn.Name = "muiscstatusDataGridViewCheckBoxColumn";
            // 
            // musicawardsDataGridViewTextBoxColumn
            // 
            this.musicawardsDataGridViewTextBoxColumn.DataPropertyName = "music_awards";
            this.musicawardsDataGridViewTextBoxColumn.HeaderText = "جوایز دریافتی";
            this.musicawardsDataGridViewTextBoxColumn.Name = "musicawardsDataGridViewTextBoxColumn";
            // 
            // music_find_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 475);
            this.Controls.Add(this.dataGridView_music_find);
            this.Controls.Add(this.lbl_findmusic);
            this.Controls.Add(this.txtbox_find_music);
            this.Controls.Add(this.btn_mfind);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "music_find_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "جستجوی موسیقی";
            this.Load += new System.EventHandler(this.music_find_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_music_find)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMusicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_findmusic;
        private System.Windows.Forms.TextBox txtbox_find_music;
        private System.Windows.Forms.Button btn_mfind;
        private System.Windows.Forms.DataGridView dataGridView_music_find;
        private Library_DatabaseDataSet12 library_DatabaseDataSet12;
        private System.Windows.Forms.BindingSource tBLMusicBindingSource;
        private Library_DatabaseDataSet12TableAdapters.TBLMusicTableAdapter tBLMusicTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musictitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicartistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicgenereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn muiscstatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicawardsDataGridViewTextBoxColumn;
    }
}