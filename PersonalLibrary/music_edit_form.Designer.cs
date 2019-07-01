namespace PersonalLibrary
{
    partial class music_edit_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(music_edit_form));
            this.dataGridView_music = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musictitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicartistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicawardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLMusicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_DatabaseDataSet9 = new PersonalLibrary.Library_DatabaseDataSet9();
            this.btn_edit_movie = new System.Windows.Forms.Button();
            this.lbl_movie_d = new System.Windows.Forms.Label();
            this.lbl_maw = new System.Windows.Forms.Label();
            this.lbl_man = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_edit_ma = new System.Windows.Forms.TextBox();
            this.txtbox_edit_man = new System.Windows.Forms.TextBox();
            this.txtbox_edit_maw = new System.Windows.Forms.TextBox();
            this.txtbox_edit_movied = new System.Windows.Forms.TextBox();
            this.txtbox_edit_mmt = new System.Windows.Forms.TextBox();
            this.tBLMusicTableAdapter = new PersonalLibrary.Library_DatabaseDataSet9TableAdapters.TBLMusicTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_music)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMusicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_music
            // 
            this.dataGridView_music.AutoGenerateColumns = false;
            this.dataGridView_music.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_music.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.musictitleDataGridViewTextBoxColumn,
            this.musicartistDataGridViewTextBoxColumn,
            this.albumnameDataGridViewTextBoxColumn,
            this.musicdescriptionDataGridViewTextBoxColumn,
            this.musicawardsDataGridViewTextBoxColumn});
            this.dataGridView_music.DataSource = this.tBLMusicBindingSource;
            this.dataGridView_music.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_music.MultiSelect = false;
            this.dataGridView_music.Name = "dataGridView_music";
            this.dataGridView_music.RowTemplate.Height = 24;
            this.dataGridView_music.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_music.Size = new System.Drawing.Size(494, 477);
            this.dataGridView_music.TabIndex = 0;
            this.dataGridView_music.SelectionChanged += new System.EventHandler(this.dataGridView_music_SelectionChanged);
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
            this.musicdescriptionDataGridViewTextBoxColumn.HeaderText = "شرح موزیک";
            this.musicdescriptionDataGridViewTextBoxColumn.Name = "musicdescriptionDataGridViewTextBoxColumn";
            // 
            // musicawardsDataGridViewTextBoxColumn
            // 
            this.musicawardsDataGridViewTextBoxColumn.DataPropertyName = "music_awards";
            this.musicawardsDataGridViewTextBoxColumn.HeaderText = "جوایز دریافتی";
            this.musicawardsDataGridViewTextBoxColumn.Name = "musicawardsDataGridViewTextBoxColumn";
            // 
            // tBLMusicBindingSource
            // 
            this.tBLMusicBindingSource.DataMember = "TBLMusic";
            this.tBLMusicBindingSource.DataSource = this.library_DatabaseDataSet9;
            // 
            // library_DatabaseDataSet9
            // 
            this.library_DatabaseDataSet9.DataSetName = "Library_DatabaseDataSet9";
            this.library_DatabaseDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_edit_movie
            // 
            this.btn_edit_movie.Location = new System.Drawing.Point(694, 443);
            this.btn_edit_movie.Name = "btn_edit_movie";
            this.btn_edit_movie.Size = new System.Drawing.Size(119, 35);
            this.btn_edit_movie.TabIndex = 22;
            this.btn_edit_movie.Text = "ویرایش کردن";
            this.btn_edit_movie.UseVisualStyleBackColor = true;
            this.btn_edit_movie.Click += new System.EventHandler(this.btn_edit_movie_Click);
            // 
            // lbl_movie_d
            // 
            this.lbl_movie_d.AutoSize = true;
            this.lbl_movie_d.Location = new System.Drawing.Point(895, 299);
            this.lbl_movie_d.Name = "lbl_movie_d";
            this.lbl_movie_d.Size = new System.Drawing.Size(69, 17);
            this.lbl_movie_d.TabIndex = 21;
            this.lbl_movie_d.Text = "شرح موسیقی";
            // 
            // lbl_maw
            // 
            this.lbl_maw.AutoSize = true;
            this.lbl_maw.Location = new System.Drawing.Point(886, 225);
            this.lbl_maw.Name = "lbl_maw";
            this.lbl_maw.Size = new System.Drawing.Size(72, 17);
            this.lbl_maw.TabIndex = 20;
            this.lbl_maw.Text = "جوایز دریافتی";
            // 
            // lbl_man
            // 
            this.lbl_man.AutoSize = true;
            this.lbl_man.Location = new System.Drawing.Point(886, 159);
            this.lbl_man.Name = "lbl_man";
            this.lbl_man.Size = new System.Drawing.Size(43, 17);
            this.lbl_man.TabIndex = 19;
            this.lbl_man.Text = "نام آلبوم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(886, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "نام خواننده";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(891, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "عنوان موسیقی";
            // 
            // txtbox_edit_ma
            // 
            this.txtbox_edit_ma.Location = new System.Drawing.Point(567, 93);
            this.txtbox_edit_ma.Name = "txtbox_edit_ma";
            this.txtbox_edit_ma.Size = new System.Drawing.Size(289, 22);
            this.txtbox_edit_ma.TabIndex = 16;
            // 
            // txtbox_edit_man
            // 
            this.txtbox_edit_man.Location = new System.Drawing.Point(567, 154);
            this.txtbox_edit_man.Name = "txtbox_edit_man";
            this.txtbox_edit_man.Size = new System.Drawing.Size(289, 22);
            this.txtbox_edit_man.TabIndex = 15;
            // 
            // txtbox_edit_maw
            // 
            this.txtbox_edit_maw.Location = new System.Drawing.Point(567, 225);
            this.txtbox_edit_maw.Name = "txtbox_edit_maw";
            this.txtbox_edit_maw.Size = new System.Drawing.Size(289, 22);
            this.txtbox_edit_maw.TabIndex = 14;
            // 
            // txtbox_edit_movied
            // 
            this.txtbox_edit_movied.Location = new System.Drawing.Point(567, 296);
            this.txtbox_edit_movied.Multiline = true;
            this.txtbox_edit_movied.Name = "txtbox_edit_movied";
            this.txtbox_edit_movied.Size = new System.Drawing.Size(289, 92);
            this.txtbox_edit_movied.TabIndex = 13;
            // 
            // txtbox_edit_mmt
            // 
            this.txtbox_edit_mmt.Location = new System.Drawing.Point(567, 40);
            this.txtbox_edit_mmt.Name = "txtbox_edit_mmt";
            this.txtbox_edit_mmt.Size = new System.Drawing.Size(289, 22);
            this.txtbox_edit_mmt.TabIndex = 12;
            // 
            // tBLMusicTableAdapter
            // 
            this.tBLMusicTableAdapter.ClearBeforeFill = true;
            // 
            // music_edit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 501);
            this.Controls.Add(this.btn_edit_movie);
            this.Controls.Add(this.lbl_movie_d);
            this.Controls.Add(this.lbl_maw);
            this.Controls.Add(this.lbl_man);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_edit_ma);
            this.Controls.Add(this.txtbox_edit_man);
            this.Controls.Add(this.txtbox_edit_maw);
            this.Controls.Add(this.txtbox_edit_movied);
            this.Controls.Add(this.txtbox_edit_mmt);
            this.Controls.Add(this.dataGridView_music);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "music_edit_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ویرایش موسیقی";
            this.Load += new System.EventHandler(this.music_edit_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_music)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMusicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_music;
        private System.Windows.Forms.Button btn_edit_movie;
        private System.Windows.Forms.Label lbl_movie_d;
        private System.Windows.Forms.Label lbl_maw;
        private System.Windows.Forms.Label lbl_man;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_edit_ma;
        private System.Windows.Forms.TextBox txtbox_edit_man;
        private System.Windows.Forms.TextBox txtbox_edit_maw;
        private System.Windows.Forms.TextBox txtbox_edit_movied;
        private System.Windows.Forms.TextBox txtbox_edit_mmt;
        private Library_DatabaseDataSet9 library_DatabaseDataSet9;
        private System.Windows.Forms.BindingSource tBLMusicBindingSource;
        private Library_DatabaseDataSet9TableAdapters.TBLMusicTableAdapter tBLMusicTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musictitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicartistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicawardsDataGridViewTextBoxColumn;
    }
}