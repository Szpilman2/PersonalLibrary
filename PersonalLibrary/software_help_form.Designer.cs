namespace PersonalLibrary
{
    partial class software_help_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(software_help_form));
            this.lbl_help2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_help2
            // 
            this.lbl_help2.AutoSize = true;
            this.lbl_help2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_help2.Location = new System.Drawing.Point(40, 152);
            this.lbl_help2.Name = "lbl_help2";
            this.lbl_help2.Size = new System.Drawing.Size(610, 144);
            this.lbl_help2.TabIndex = 0;
            this.lbl_help2.Text = resources.GetString("lbl_help2.Text");
            this.lbl_help2.Click += new System.EventHandler(this.lbl_help2_Click);
            // 
            // software_help_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 475);
            this.Controls.Add(this.lbl_help2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "software_help_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "راهنمای نرم افزار";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_help2;
    }
}