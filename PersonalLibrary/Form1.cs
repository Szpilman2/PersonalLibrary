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
    public partial class main_form : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public main_form()
        {
            InitializeComponent();
        }
        
        private void book_add_Click(object sender, EventArgs e)
        {
            book_add_form book_add = new book_add_form();
            book_add.Show();
        }

        private void book_edit_Click(object sender, EventArgs e)
        {
            book_edit_form book_edit = new book_edit_form();
            book_edit.Show();
        }

        private void book_find_Click(object sender, EventArgs e)
        {
            book_find_form book_find = new book_find_form();
            book_find.Show();
        }

        private void book_delete_Click(object sender, EventArgs e)
        {
            book_delete_form book_delete = new book_delete_form();
            book_delete.Show();
        }

        private void music_add_Click(object sender, EventArgs e)
        {
            music_add_form music_add = new music_add_form();
            music_add.Show();
        }

        private void music_edit_Click(object sender, EventArgs e)
        {
            music_edit_form music_edit = new music_edit_form();
            music_edit.Show();
        }

        private void music_find_Click(object sender, EventArgs e)
        {
            music_find_form music_find = new music_find_form();
            music_find.Show();
        }

        private void music_delete_Click(object sender, EventArgs e)
        {
            music_delete_form music_delete = new music_delete_form();
            music_delete.Show();
        }

        private void video_add_Click(object sender, EventArgs e)
        {
            video_add_form video_add = new video_add_form();
            video_add.Show();
        }

        private void video_edit_Click(object sender, EventArgs e)
        {
            video_edit_form video_edit = new video_edit_form();
            video_edit.Show();
        }

        private void video_find_Click(object sender, EventArgs e)
        {
            video_find_form video_find = new video_find_form();
            video_find.Show();
        }

        private void video_delete_Click(object sender, EventArgs e)
        {
            video_delete_form video_delete = new video_delete_form();
            video_delete.Show();
        }

        private void software_help_tab_Click(object sender, EventArgs e)
        {
            software_help_form help = new software_help_form();
            help.Show();
        }

        private void about_us_tab_Click(object sender, EventArgs e)
        {
            about_us_form about = new about_us_form();
            about.Show();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
           // conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Library_Database.mdf;Integrated Security=True";
           // conn.Open();
        }
    }
}
