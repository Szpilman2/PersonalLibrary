namespace PersonalLibrary
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.book_tab = new System.Windows.Forms.ToolStripMenuItem();
            this.book_add = new System.Windows.Forms.ToolStripMenuItem();
            this.book_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.book_find = new System.Windows.Forms.ToolStripMenuItem();
            this.book_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.music_tab = new System.Windows.Forms.ToolStripMenuItem();
            this.music_add = new System.Windows.Forms.ToolStripMenuItem();
            this.music_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.music_find = new System.Windows.Forms.ToolStripMenuItem();
            this.music_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.video_tab = new System.Windows.Forms.ToolStripMenuItem();
            this.video_add = new System.Windows.Forms.ToolStripMenuItem();
            this.video_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.video_find = new System.Windows.Forms.ToolStripMenuItem();
            this.video_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.software_help_tab = new System.Windows.Forms.ToolStripMenuItem();
            this.about_us_tab = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.book_tab,
            this.music_tab,
            this.video_tab,
            this.software_help_tab,
            this.about_us_tab});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(842, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // book_tab
            // 
            this.book_tab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.book_add,
            this.book_edit,
            this.book_find,
            this.book_delete});
            this.book_tab.Name = "book_tab";
            this.book_tab.Size = new System.Drawing.Size(52, 24);
            this.book_tab.Text = "کتاب";
            // 
            // book_add
            // 
            this.book_add.Name = "book_add";
            this.book_add.Size = new System.Drawing.Size(130, 26);
            this.book_add.Text = "افزودن";
            this.book_add.Click += new System.EventHandler(this.book_add_Click);
            // 
            // book_edit
            // 
            this.book_edit.Name = "book_edit";
            this.book_edit.Size = new System.Drawing.Size(130, 26);
            this.book_edit.Text = "ویرایش";
            this.book_edit.Click += new System.EventHandler(this.book_edit_Click);
            // 
            // book_find
            // 
            this.book_find.Name = "book_find";
            this.book_find.Size = new System.Drawing.Size(130, 26);
            this.book_find.Text = "جستجو";
            this.book_find.Click += new System.EventHandler(this.book_find_Click);
            // 
            // book_delete
            // 
            this.book_delete.Name = "book_delete";
            this.book_delete.Size = new System.Drawing.Size(130, 26);
            this.book_delete.Text = "حذف";
            this.book_delete.Click += new System.EventHandler(this.book_delete_Click);
            // 
            // music_tab
            // 
            this.music_tab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.music_add,
            this.music_edit,
            this.music_find,
            this.music_delete});
            this.music_tab.Name = "music_tab";
            this.music_tab.Size = new System.Drawing.Size(77, 24);
            this.music_tab.Text = "موسیقی";
            // 
            // music_add
            // 
            this.music_add.Name = "music_add";
            this.music_add.Size = new System.Drawing.Size(130, 26);
            this.music_add.Text = "افزودن";
            this.music_add.Click += new System.EventHandler(this.music_add_Click);
            // 
            // music_edit
            // 
            this.music_edit.Name = "music_edit";
            this.music_edit.Size = new System.Drawing.Size(130, 26);
            this.music_edit.Text = "ویرایش";
            this.music_edit.Click += new System.EventHandler(this.music_edit_Click);
            // 
            // music_find
            // 
            this.music_find.Name = "music_find";
            this.music_find.Size = new System.Drawing.Size(130, 26);
            this.music_find.Text = "جستجو";
            this.music_find.Click += new System.EventHandler(this.music_find_Click);
            // 
            // music_delete
            // 
            this.music_delete.Name = "music_delete";
            this.music_delete.Size = new System.Drawing.Size(130, 26);
            this.music_delete.Text = "حذف";
            this.music_delete.Click += new System.EventHandler(this.music_delete_Click);
            // 
            // video_tab
            // 
            this.video_tab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.video_add,
            this.video_edit,
            this.video_find,
            this.video_delete});
            this.video_tab.Name = "video_tab";
            this.video_tab.Size = new System.Drawing.Size(48, 24);
            this.video_tab.Text = "فیلم";
            // 
            // video_add
            // 
            this.video_add.Name = "video_add";
            this.video_add.Size = new System.Drawing.Size(130, 26);
            this.video_add.Text = "افزودن";
            this.video_add.Click += new System.EventHandler(this.video_add_Click);
            // 
            // video_edit
            // 
            this.video_edit.Name = "video_edit";
            this.video_edit.Size = new System.Drawing.Size(130, 26);
            this.video_edit.Text = "ویرایش";
            this.video_edit.Click += new System.EventHandler(this.video_edit_Click);
            // 
            // video_find
            // 
            this.video_find.Name = "video_find";
            this.video_find.Size = new System.Drawing.Size(130, 26);
            this.video_find.Text = "جستجو";
            this.video_find.Click += new System.EventHandler(this.video_find_Click);
            // 
            // video_delete
            // 
            this.video_delete.Name = "video_delete";
            this.video_delete.Size = new System.Drawing.Size(130, 26);
            this.video_delete.Text = "حذف";
            this.video_delete.Click += new System.EventHandler(this.video_delete_Click);
            // 
            // software_help_tab
            // 
            this.software_help_tab.Name = "software_help_tab";
            this.software_help_tab.Size = new System.Drawing.Size(123, 24);
            this.software_help_tab.Text = "راهنمای نرم افزار";
            this.software_help_tab.Click += new System.EventHandler(this.software_help_tab_Click);
            // 
            // about_us_tab
            // 
            this.about_us_tab.Name = "about_us_tab";
            this.about_us_tab.Size = new System.Drawing.Size(74, 24);
            this.about_us_tab.Text = "درباره ما";
            this.about_us_tab.Click += new System.EventHandler(this.about_us_tab_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 524);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "سیستم مدیریت کتابخانه شخصی";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem book_tab;
        private System.Windows.Forms.ToolStripMenuItem book_add;
        private System.Windows.Forms.ToolStripMenuItem book_edit;
        private System.Windows.Forms.ToolStripMenuItem book_find;
        private System.Windows.Forms.ToolStripMenuItem book_delete;
        private System.Windows.Forms.ToolStripMenuItem music_tab;
        private System.Windows.Forms.ToolStripMenuItem music_add;
        private System.Windows.Forms.ToolStripMenuItem music_edit;
        private System.Windows.Forms.ToolStripMenuItem music_find;
        private System.Windows.Forms.ToolStripMenuItem music_delete;
        private System.Windows.Forms.ToolStripMenuItem video_tab;
        private System.Windows.Forms.ToolStripMenuItem video_add;
        private System.Windows.Forms.ToolStripMenuItem video_edit;
        private System.Windows.Forms.ToolStripMenuItem video_find;
        private System.Windows.Forms.ToolStripMenuItem video_delete;
        private System.Windows.Forms.ToolStripMenuItem software_help_tab;
        private System.Windows.Forms.ToolStripMenuItem about_us_tab;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

