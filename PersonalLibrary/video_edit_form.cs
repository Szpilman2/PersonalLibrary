using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonalLibrary
{
    public partial class video_edit_form : Form
    {
        SqlConnection conn2 = new SqlConnection();
        public video_edit_form()
        {
            InitializeComponent();
        }

        private void video_edit_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DatabaseDataSet10.TBLVideo' table. You can move, or remove it, as needed.
            this.tBLVideoTableAdapter.Fill(this.library_DatabaseDataSet10.TBLVideo);
            updateTextBoxes();
            conn2 = tBLVideoTableAdapter.Connection;
            conn2.Open();
        }
        private void updateTextBoxes()
        {

            txtbox_edit_ti.Text = (string)dataGridView_video.CurrentRow.Cells[1].Value;
            txtbox_edit_d.Text = (string)dataGridView_video.CurrentRow.Cells[2].Value;
            txtbox_edit_yb.Text = (string)dataGridView_video.CurrentRow.Cells[3].Value;
            txtbox_edit_aw.Text = (string)dataGridView_video.CurrentRow.Cells[5].Value;
            txtbox_edit_md.Text = (string)dataGridView_video.CurrentRow.Cells[4].Value;

        }

        private void dataGridView_video_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_video.CurrentRow == null)
            {
                return;
            }
            updateTextBoxes();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView_video.CurrentRow == null)
            {
                MessageBox.Show("Not selected anything!");
                return;
            }
            SqlCommand query = new SqlCommand(@"UPDATE TBLvideo SET video_title = @title, video_director = @director, video_year_of_build = @year, video_description = @description,video_awards=@award WHERE id = @BookID", conn2);
            query.Parameters.AddWithValue("title", txtbox_edit_ti.Text);
            query.Parameters.AddWithValue("director", txtbox_edit_d.Text);
            query.Parameters.AddWithValue("year", txtbox_edit_yb.Text);
            query.Parameters.AddWithValue("description", txtbox_edit_md.Text);
            query.Parameters.AddWithValue("award", txtbox_edit_aw.Text);
            query.Parameters.AddWithValue("BookID", (int)dataGridView_video.CurrentRow.Cells[0].Value);

            query.ExecuteNonQuery();
            MessageBox.Show("Edited Successfuly!");
            this.tBLVideoTableAdapter.Fill(this.library_DatabaseDataSet10.TBLVideo);

        }
    }
}
