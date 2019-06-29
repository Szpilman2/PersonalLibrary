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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(video_find_form));
            this.lbl_find_movie = new System.Windows.Forms.Label();
            this.textBox_find_movie = new System.Windows.Forms.TextBox();
            this.btn_movie_find = new System.Windows.Forms.Button();
            this.dataGridView_movie_find = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_movie_find)).BeginInit();
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
            this.dataGridView_movie_find.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_movie_find.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_movie_find.Name = "dataGridView_movie_find";
            this.dataGridView_movie_find.RowTemplate.Height = 24;
            this.dataGridView_movie_find.Size = new System.Drawing.Size(651, 399);
            this.dataGridView_movie_find.TabIndex = 6;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_movie_find)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_find_movie;
        private System.Windows.Forms.TextBox textBox_find_movie;
        private System.Windows.Forms.Button btn_movie_find;
        private System.Windows.Forms.DataGridView dataGridView_movie_find;
    }
}