namespace PersonalLibrary
{
    partial class video_add_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(video_add_form));
            this.radiobtn_half_seen = new System.Windows.Forms.RadioButton();
            this.lbl_is_seen = new System.Windows.Forms.Label();
            this.radiobtn_isnot_seen = new System.Windows.Forms.RadioButton();
            this.radiobtn_is_seen = new System.Windows.Forms.RadioButton();
            this.btn_add_movie = new System.Windows.Forms.Button();
            this.lbl_video_category = new System.Windows.Forms.Label();
            this.combox_video = new System.Windows.Forms.ComboBox();
            this.txt_video_description = new System.Windows.Forms.TextBox();
            this.lbl_video_description = new System.Windows.Forms.Label();
            this.txt_video_publish_year = new System.Windows.Forms.TextBox();
            this.lbl_video_year = new System.Windows.Forms.Label();
            this.txt_video_director = new System.Windows.Forms.TextBox();
            this.lbl_video_director = new System.Windows.Forms.Label();
            this.txt_video_name = new System.Windows.Forms.TextBox();
            this.lbl_video_name = new System.Windows.Forms.Label();
            this.txtbox_movie_awards = new System.Windows.Forms.TextBox();
            this.lbl_movie_awards = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radiobtn_half_seen
            // 
            this.radiobtn_half_seen.AutoSize = true;
            this.radiobtn_half_seen.Location = new System.Drawing.Point(534, 147);
            this.radiobtn_half_seen.Name = "radiobtn_half_seen";
            this.radiobtn_half_seen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobtn_half_seen.Size = new System.Drawing.Size(113, 21);
            this.radiobtn_half_seen.TabIndex = 29;
            this.radiobtn_half_seen.Text = "قسمتی مشاهده شده\r\n";
            this.radiobtn_half_seen.UseVisualStyleBackColor = true;
            // 
            // lbl_is_seen
            // 
            this.lbl_is_seen.AutoSize = true;
            this.lbl_is_seen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_is_seen.Location = new System.Drawing.Point(351, 91);
            this.lbl_is_seen.Name = "lbl_is_seen";
            this.lbl_is_seen.Size = new System.Drawing.Size(167, 21);
            this.lbl_is_seen.TabIndex = 28;
            this.lbl_is_seen.Text = "وضعیت مشاهده فیلم:";
            // 
            // radiobtn_isnot_seen
            // 
            this.radiobtn_isnot_seen.AutoSize = true;
            this.radiobtn_isnot_seen.Location = new System.Drawing.Point(534, 120);
            this.radiobtn_isnot_seen.Name = "radiobtn_isnot_seen";
            this.radiobtn_isnot_seen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobtn_isnot_seen.Size = new System.Drawing.Size(84, 21);
            this.radiobtn_isnot_seen.TabIndex = 27;
            this.radiobtn_isnot_seen.Text = "مشاهده نشده";
            this.radiobtn_isnot_seen.UseVisualStyleBackColor = true;
            // 
            // radiobtn_is_seen
            // 
            this.radiobtn_is_seen.AutoSize = true;
            this.radiobtn_is_seen.Checked = true;
            this.radiobtn_is_seen.Location = new System.Drawing.Point(534, 93);
            this.radiobtn_is_seen.Name = "radiobtn_is_seen";
            this.radiobtn_is_seen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobtn_is_seen.Size = new System.Drawing.Size(81, 21);
            this.radiobtn_is_seen.TabIndex = 26;
            this.radiobtn_is_seen.TabStop = true;
            this.radiobtn_is_seen.Text = "مشاهده شده";
            this.radiobtn_is_seen.UseVisualStyleBackColor = true;
            // 
            // btn_add_movie
            // 
            this.btn_add_movie.Location = new System.Drawing.Point(300, 397);
            this.btn_add_movie.Name = "btn_add_movie";
            this.btn_add_movie.Size = new System.Drawing.Size(98, 36);
            this.btn_add_movie.TabIndex = 25;
            this.btn_add_movie.Text = "افزودن فیلم";
            this.btn_add_movie.UseVisualStyleBackColor = true;
            // 
            // lbl_video_category
            // 
            this.lbl_video_category.AutoSize = true;
            this.lbl_video_category.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_video_category.Location = new System.Drawing.Point(351, 43);
            this.lbl_video_category.Name = "lbl_video_category";
            this.lbl_video_category.Size = new System.Drawing.Size(138, 21);
            this.lbl_video_category.TabIndex = 24;
            this.lbl_video_category.Text = "دسته بندی فیلم :";
            // 
            // combox_video
            // 
            this.combox_video.FormattingEnabled = true;
            this.combox_video.Items.AddRange(new object[] {
            "اکشن",
            "درام",
            "طنز",
            "اجتماعی",
            "انیمیشن"});
            this.combox_video.Location = new System.Drawing.Point(507, 42);
            this.combox_video.Name = "combox_video";
            this.combox_video.Size = new System.Drawing.Size(140, 24);
            this.combox_video.TabIndex = 23;
            // 
            // txt_video_description
            // 
            this.txt_video_description.Location = new System.Drawing.Point(132, 190);
            this.txt_video_description.Multiline = true;
            this.txt_video_description.Name = "txt_video_description";
            this.txt_video_description.Size = new System.Drawing.Size(156, 71);
            this.txt_video_description.TabIndex = 22;
            this.txt_video_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_video_description
            // 
            this.lbl_video_description.AutoSize = true;
            this.lbl_video_description.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_video_description.Location = new System.Drawing.Point(28, 189);
            this.lbl_video_description.Name = "lbl_video_description";
            this.lbl_video_description.Size = new System.Drawing.Size(86, 21);
            this.lbl_video_description.TabIndex = 21;
            this.lbl_video_description.Text = "شرح فیلم:";
            // 
            // txt_video_publish_year
            // 
            this.txt_video_publish_year.Location = new System.Drawing.Point(134, 139);
            this.txt_video_publish_year.Name = "txt_video_publish_year";
            this.txt_video_publish_year.Size = new System.Drawing.Size(156, 22);
            this.txt_video_publish_year.TabIndex = 20;
            this.txt_video_publish_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_video_year
            // 
            this.lbl_video_year.AutoSize = true;
            this.lbl_video_year.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_video_year.Location = new System.Drawing.Point(13, 138);
            this.lbl_video_year.Name = "lbl_video_year";
            this.lbl_video_year.Size = new System.Drawing.Size(103, 21);
            this.lbl_video_year.TabIndex = 19;
            this.lbl_video_year.Text = "سال ساخت:";
            // 
            // txt_video_director
            // 
            this.txt_video_director.Location = new System.Drawing.Point(134, 90);
            this.txt_video_director.Name = "txt_video_director";
            this.txt_video_director.Size = new System.Drawing.Size(156, 22);
            this.txt_video_director.TabIndex = 18;
            this.txt_video_director.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_video_director
            // 
            this.lbl_video_director.AutoSize = true;
            this.lbl_video_director.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_video_director.Location = new System.Drawing.Point(30, 89);
            this.lbl_video_director.Name = "lbl_video_director";
            this.lbl_video_director.Size = new System.Drawing.Size(73, 21);
            this.lbl_video_director.TabIndex = 17;
            this.lbl_video_director.Text = "کارگردان:";
            // 
            // txt_video_name
            // 
            this.txt_video_name.Location = new System.Drawing.Point(134, 42);
            this.txt_video_name.Name = "txt_video_name";
            this.txt_video_name.Size = new System.Drawing.Size(156, 22);
            this.txt_video_name.TabIndex = 16;
            this.txt_video_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_video_name
            // 
            this.lbl_video_name.AutoSize = true;
            this.lbl_video_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_video_name.Location = new System.Drawing.Point(30, 41);
            this.lbl_video_name.Name = "lbl_video_name";
            this.lbl_video_name.Size = new System.Drawing.Size(96, 21);
            this.lbl_video_name.TabIndex = 15;
            this.lbl_video_name.Text = "عنوان فیلم :";
            // 
            // txtbox_movie_awards
            // 
            this.txtbox_movie_awards.Location = new System.Drawing.Point(491, 209);
            this.txtbox_movie_awards.Multiline = true;
            this.txtbox_movie_awards.Name = "txtbox_movie_awards";
            this.txtbox_movie_awards.Size = new System.Drawing.Size(156, 71);
            this.txtbox_movie_awards.TabIndex = 31;
            this.txtbox_movie_awards.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_movie_awards
            // 
            this.lbl_movie_awards.AutoSize = true;
            this.lbl_movie_awards.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movie_awards.Location = new System.Drawing.Point(363, 208);
            this.lbl_movie_awards.Name = "lbl_movie_awards";
            this.lbl_movie_awards.Size = new System.Drawing.Size(110, 21);
            this.lbl_movie_awards.TabIndex = 30;
            this.lbl_movie_awards.Text = "جوایز دریافتی:";
            // 
            // video_add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 475);
            this.Controls.Add(this.txtbox_movie_awards);
            this.Controls.Add(this.lbl_movie_awards);
            this.Controls.Add(this.radiobtn_half_seen);
            this.Controls.Add(this.lbl_is_seen);
            this.Controls.Add(this.radiobtn_isnot_seen);
            this.Controls.Add(this.radiobtn_is_seen);
            this.Controls.Add(this.btn_add_movie);
            this.Controls.Add(this.lbl_video_category);
            this.Controls.Add(this.combox_video);
            this.Controls.Add(this.txt_video_description);
            this.Controls.Add(this.lbl_video_description);
            this.Controls.Add(this.txt_video_publish_year);
            this.Controls.Add(this.lbl_video_year);
            this.Controls.Add(this.txt_video_director);
            this.Controls.Add(this.lbl_video_director);
            this.Controls.Add(this.txt_video_name);
            this.Controls.Add(this.lbl_video_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "video_add_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "افزودن فیلم";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radiobtn_half_seen;
        private System.Windows.Forms.Label lbl_is_seen;
        private System.Windows.Forms.RadioButton radiobtn_isnot_seen;
        private System.Windows.Forms.RadioButton radiobtn_is_seen;
        private System.Windows.Forms.Button btn_add_movie;
        private System.Windows.Forms.Label lbl_video_category;
        private System.Windows.Forms.ComboBox combox_video;
        private System.Windows.Forms.TextBox txt_video_description;
        private System.Windows.Forms.Label lbl_video_description;
        private System.Windows.Forms.TextBox txt_video_publish_year;
        private System.Windows.Forms.Label lbl_video_year;
        private System.Windows.Forms.TextBox txt_video_director;
        private System.Windows.Forms.Label lbl_video_director;
        private System.Windows.Forms.TextBox txt_video_name;
        private System.Windows.Forms.Label lbl_video_name;
        private System.Windows.Forms.TextBox txtbox_movie_awards;
        private System.Windows.Forms.Label lbl_movie_awards;
    }
}