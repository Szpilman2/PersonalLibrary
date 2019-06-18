namespace PersonalLibrary
{
    partial class about_us_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about_us_form));
            this.lbl_about_us = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_about_us
            // 
            this.lbl_about_us.AutoSize = true;
            this.lbl_about_us.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_about_us.Location = new System.Drawing.Point(222, 85);
            this.lbl_about_us.Name = "lbl_about_us";
            this.lbl_about_us.Size = new System.Drawing.Size(284, 24);
            this.lbl_about_us.TabIndex = 0;
            this.lbl_about_us.Text = "پروژه درس اصول طراحی نرم افزار ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 161);
            this.label1.TabIndex = 1;
            this.label1.Text = "این پروژه به سرپرستی جناب آقای مهندس مشایخ در بهار سال 98 \r\nتوسط دانشجویان زیر نو" +
    "شته شده است:\r\nپیمان شعبانی\r\nمحمد تیموری\r\nمحمدحسین خوش رفتار\r\nعلی سلطانی راد\r\nمحم" +
    "دحسن چمن مطلق\r\n";
            // 
            // about_us_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_about_us);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "about_us_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "درباره ما";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_about_us;
        private System.Windows.Forms.Label label1;
    }
}