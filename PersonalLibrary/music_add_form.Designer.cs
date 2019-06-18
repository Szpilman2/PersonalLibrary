namespace PersonalLibrary
{
    partial class music_add_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(music_add_form));
            this.radiobtn_half_listen = new System.Windows.Forms.RadioButton();
            this.lbl_is_listen = new System.Windows.Forms.Label();
            this.radiobtn_isnot_listen = new System.Windows.Forms.RadioButton();
            this.radiobtn_is_listen = new System.Windows.Forms.RadioButton();
            this.btn_add_music = new System.Windows.Forms.Button();
            this.lbl_music_category = new System.Windows.Forms.Label();
            this.combox_music = new System.Windows.Forms.ComboBox();
            this.txt_music_description = new System.Windows.Forms.TextBox();
            this.lbl_music_description = new System.Windows.Forms.Label();
            this.txt_music_album_name = new System.Windows.Forms.TextBox();
            this.lbl_album_name = new System.Windows.Forms.Label();
            this.txt_music_artist = new System.Windows.Forms.TextBox();
            this.lbl_music_artist = new System.Windows.Forms.Label();
            this.txt_music_name = new System.Windows.Forms.TextBox();
            this.lbl_music_name = new System.Windows.Forms.Label();
            this.txtbox_music_awards = new System.Windows.Forms.TextBox();
            this.lbl_music_awards = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radiobtn_half_listen
            // 
            this.radiobtn_half_listen.AutoSize = true;
            this.radiobtn_half_listen.Location = new System.Drawing.Point(534, 147);
            this.radiobtn_half_listen.Name = "radiobtn_half_listen";
            this.radiobtn_half_listen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobtn_half_listen.Size = new System.Drawing.Size(53, 21);
            this.radiobtn_half_listen.TabIndex = 29;
            this.radiobtn_half_listen.Text = "نصفه";
            this.radiobtn_half_listen.UseVisualStyleBackColor = true;
            // 
            // lbl_is_listen
            // 
            this.lbl_is_listen.AutoSize = true;
            this.lbl_is_listen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_is_listen.Location = new System.Drawing.Point(361, 91);
            this.lbl_is_listen.Name = "lbl_is_listen";
            this.lbl_is_listen.Size = new System.Drawing.Size(137, 21);
            this.lbl_is_listen.TabIndex = 28;
            this.lbl_is_listen.Text = "وضعیت موسیقی:";
            // 
            // radiobtn_isnot_listen
            // 
            this.radiobtn_isnot_listen.AutoSize = true;
            this.radiobtn_isnot_listen.Location = new System.Drawing.Point(534, 120);
            this.radiobtn_isnot_listen.Name = "radiobtn_isnot_listen";
            this.radiobtn_isnot_listen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobtn_isnot_listen.Size = new System.Drawing.Size(94, 21);
            this.radiobtn_isnot_listen.TabIndex = 27;
            this.radiobtn_isnot_listen.Text = "گوش نکرده ام";
            this.radiobtn_isnot_listen.UseVisualStyleBackColor = true;
            // 
            // radiobtn_is_listen
            // 
            this.radiobtn_is_listen.AutoSize = true;
            this.radiobtn_is_listen.Checked = true;
            this.radiobtn_is_listen.Location = new System.Drawing.Point(534, 93);
            this.radiobtn_is_listen.Name = "radiobtn_is_listen";
            this.radiobtn_is_listen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobtn_is_listen.Size = new System.Drawing.Size(91, 21);
            this.radiobtn_is_listen.TabIndex = 26;
            this.radiobtn_is_listen.TabStop = true;
            this.radiobtn_is_listen.Text = "گوش کرده ام";
            this.radiobtn_is_listen.UseVisualStyleBackColor = true;
            // 
            // btn_add_music
            // 
            this.btn_add_music.Location = new System.Drawing.Point(300, 397);
            this.btn_add_music.Name = "btn_add_music";
            this.btn_add_music.Size = new System.Drawing.Size(98, 36);
            this.btn_add_music.TabIndex = 25;
            this.btn_add_music.Text = "افزودن موسیقی";
            this.btn_add_music.UseVisualStyleBackColor = true;
            // 
            // lbl_music_category
            // 
            this.lbl_music_category.AutoSize = true;
            this.lbl_music_category.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_music_category.Location = new System.Drawing.Point(330, 43);
            this.lbl_music_category.Name = "lbl_music_category";
            this.lbl_music_category.Size = new System.Drawing.Size(168, 21);
            this.lbl_music_category.TabIndex = 24;
            this.lbl_music_category.Text = "دسته بندی موسیقی:";
            this.lbl_music_category.Click += new System.EventHandler(this.lbl_music_category_Click);
            // 
            // combox_music
            // 
            this.combox_music.FormattingEnabled = true;
            this.combox_music.Items.AddRange(new object[] {
            "پاپ",
            "راک",
            "قدیمی",
            "رپ"});
            this.combox_music.Location = new System.Drawing.Point(507, 42);
            this.combox_music.Name = "combox_music";
            this.combox_music.Size = new System.Drawing.Size(140, 24);
            this.combox_music.TabIndex = 23;
            // 
            // txt_music_description
            // 
            this.txt_music_description.Location = new System.Drawing.Point(132, 190);
            this.txt_music_description.Multiline = true;
            this.txt_music_description.Name = "txt_music_description";
            this.txt_music_description.Size = new System.Drawing.Size(156, 71);
            this.txt_music_description.TabIndex = 22;
            this.txt_music_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_music_description
            // 
            this.lbl_music_description.AutoSize = true;
            this.lbl_music_description.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_music_description.Location = new System.Drawing.Point(13, 193);
            this.lbl_music_description.Name = "lbl_music_description";
            this.lbl_music_description.Size = new System.Drawing.Size(99, 17);
            this.lbl_music_description.TabIndex = 21;
            this.lbl_music_description.Text = "شرح موسیقی:";
            // 
            // txt_music_album_name
            // 
            this.txt_music_album_name.Location = new System.Drawing.Point(134, 139);
            this.txt_music_album_name.Name = "txt_music_album_name";
            this.txt_music_album_name.Size = new System.Drawing.Size(156, 22);
            this.txt_music_album_name.TabIndex = 20;
            this.txt_music_album_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_album_name
            // 
            this.lbl_album_name.AutoSize = true;
            this.lbl_album_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_album_name.Location = new System.Drawing.Point(30, 138);
            this.lbl_album_name.Name = "lbl_album_name";
            this.lbl_album_name.Size = new System.Drawing.Size(74, 21);
            this.lbl_album_name.TabIndex = 19;
            this.lbl_album_name.Text = "نام آلبوم:";
            // 
            // txt_music_artist
            // 
            this.txt_music_artist.Location = new System.Drawing.Point(134, 90);
            this.txt_music_artist.Name = "txt_music_artist";
            this.txt_music_artist.Size = new System.Drawing.Size(156, 22);
            this.txt_music_artist.TabIndex = 18;
            this.txt_music_artist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_music_artist
            // 
            this.lbl_music_artist.AutoSize = true;
            this.lbl_music_artist.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_music_artist.Location = new System.Drawing.Point(30, 89);
            this.lbl_music_artist.Name = "lbl_music_artist";
            this.lbl_music_artist.Size = new System.Drawing.Size(72, 21);
            this.lbl_music_artist.TabIndex = 17;
            this.lbl_music_artist.Text = "خواننده :";
            // 
            // txt_music_name
            // 
            this.txt_music_name.Location = new System.Drawing.Point(144, 42);
            this.txt_music_name.Name = "txt_music_name";
            this.txt_music_name.Size = new System.Drawing.Size(156, 22);
            this.txt_music_name.TabIndex = 16;
            this.txt_music_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_music_name
            // 
            this.lbl_music_name.AutoSize = true;
            this.lbl_music_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_music_name.Location = new System.Drawing.Point(12, 41);
            this.lbl_music_name.Name = "lbl_music_name";
            this.lbl_music_name.Size = new System.Drawing.Size(126, 21);
            this.lbl_music_name.TabIndex = 15;
            this.lbl_music_name.Text = "عنوان موسیقی:";
            // 
            // txtbox_music_awards
            // 
            this.txtbox_music_awards.Location = new System.Drawing.Point(491, 210);
            this.txtbox_music_awards.Multiline = true;
            this.txtbox_music_awards.Name = "txtbox_music_awards";
            this.txtbox_music_awards.Size = new System.Drawing.Size(156, 71);
            this.txtbox_music_awards.TabIndex = 31;
            this.txtbox_music_awards.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_music_awards
            // 
            this.lbl_music_awards.AutoSize = true;
            this.lbl_music_awards.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_music_awards.Location = new System.Drawing.Point(372, 213);
            this.lbl_music_awards.Name = "lbl_music_awards";
            this.lbl_music_awards.Size = new System.Drawing.Size(90, 17);
            this.lbl_music_awards.TabIndex = 30;
            this.lbl_music_awards.Text = "جوایز دریافتی:";
            // 
            // music_add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 475);
            this.Controls.Add(this.txtbox_music_awards);
            this.Controls.Add(this.lbl_music_awards);
            this.Controls.Add(this.radiobtn_half_listen);
            this.Controls.Add(this.lbl_is_listen);
            this.Controls.Add(this.radiobtn_isnot_listen);
            this.Controls.Add(this.radiobtn_is_listen);
            this.Controls.Add(this.btn_add_music);
            this.Controls.Add(this.lbl_music_category);
            this.Controls.Add(this.combox_music);
            this.Controls.Add(this.txt_music_description);
            this.Controls.Add(this.lbl_music_description);
            this.Controls.Add(this.txt_music_album_name);
            this.Controls.Add(this.lbl_album_name);
            this.Controls.Add(this.txt_music_artist);
            this.Controls.Add(this.lbl_music_artist);
            this.Controls.Add(this.txt_music_name);
            this.Controls.Add(this.lbl_music_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "music_add_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "افزودن موسیقی";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radiobtn_half_listen;
        private System.Windows.Forms.Label lbl_is_listen;
        private System.Windows.Forms.RadioButton radiobtn_isnot_listen;
        private System.Windows.Forms.RadioButton radiobtn_is_listen;
        private System.Windows.Forms.Button btn_add_music;
        private System.Windows.Forms.Label lbl_music_category;
        private System.Windows.Forms.ComboBox combox_music;
        private System.Windows.Forms.TextBox txt_music_description;
        private System.Windows.Forms.Label lbl_music_description;
        private System.Windows.Forms.TextBox txt_music_album_name;
        private System.Windows.Forms.Label lbl_album_name;
        private System.Windows.Forms.TextBox txt_music_artist;
        private System.Windows.Forms.Label lbl_music_artist;
        private System.Windows.Forms.TextBox txt_music_name;
        private System.Windows.Forms.Label lbl_music_name;
        private System.Windows.Forms.TextBox txtbox_music_awards;
        private System.Windows.Forms.Label lbl_music_awards;
    }
}