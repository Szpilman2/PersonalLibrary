using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLibrary
{
    public partial class music_edit_form : Form
    {
        SqlConnection conn2 = new SqlConnection();
        public music_edit_form()
        {
            InitializeComponent();
        }

        private void music_edit_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DatabaseDataSet9.TBLMusic' table. You can move, or remove it, as needed.
            this.tBLMusicTableAdapter.Fill(this.library_DatabaseDataSet9.TBLMusic);
            updateTextBoxes();
            conn2 = tBLMusicTableAdapter.Connection;
            conn2.Open();

        }

        private void updateTextBoxes()
        {
            if (dataGridView_music.CurrentRow == null)
            {
                MessageBox.Show("first insert something");
                Close();
            }
            else
            {

                txtbox_edit_ma.Text = (string)dataGridView_music.CurrentRow.Cells[2].Value;
                txtbox_edit_mmt.Text = (string)dataGridView_music.CurrentRow.Cells[1].Value;
                txtbox_edit_man.Text = (string)dataGridView_music.CurrentRow.Cells[3].Value;
                txtbox_edit_movied.Text = (string)dataGridView_music.CurrentRow.Cells[4].Value;
            }

        }

       

        private void dataGridView_music_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView_music.CurrentRow == null)
            {
                return;
            }
            updateTextBoxes();
        }

        private void btn_edit_movie_Click(object sender, EventArgs e)
        {
            if (dataGridView_music.CurrentRow == null)
            {
                MessageBox.Show("Not selected anything!");
                return;
            }
            SqlCommand query = new SqlCommand(@"UPDATE TBLmusic SET music_title = @title, music_artist = @artist, album_name = @albumname, music_description = @description,music_awards=@award WHERE id = @BookID", conn2);
            query.Parameters.AddWithValue("title", txtbox_edit_mmt.Text);
            query.Parameters.AddWithValue("artist", txtbox_edit_ma.Text);
            query.Parameters.AddWithValue("albumname", txtbox_edit_man.Text);
            query.Parameters.AddWithValue("description", txtbox_edit_movied.Text);
            query.Parameters.AddWithValue("award", txtbox_edit_maw.Text);
            query.Parameters.AddWithValue("BookID", (int)dataGridView_music.CurrentRow.Cells[0].Value);

            query.ExecuteNonQuery();
            MessageBox.Show("Edited Successfuly!");
            this.tBLMusicTableAdapter.Fill(this.library_DatabaseDataSet9.TBLMusic);
         
        }
    }
}
