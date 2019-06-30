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
    public partial class music_add_form : Form
    {
        SqlConnection conn1 = new SqlConnection();
        SqlCommand cmd1 = new SqlCommand();
        SqlDataAdapter da1 = new SqlDataAdapter();
        DataSet ds1 = new DataSet();
        public music_add_form()
        {
            InitializeComponent();
        }

        private void lbl_music_category_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_music_Click(object sender, EventArgs e)
        {
            string commandString = @"INSERT INTO TBLmusic(music_title,music_artist,album_name,music_description,music_genere,muisc_status,music_awards) VALUES(@title,@artist,@album_name, @desc, @genre,'FALSE',@awards)";


            SqlCommand command = new SqlCommand(commandString, conn1);
            command.Parameters.AddWithValue("artist", txt_music_artist.Text);
            command.Parameters.AddWithValue("genre", combox_music.Text);
            command.Parameters.AddWithValue("title", txt_music_name.Text);
            command.Parameters.AddWithValue("desc", txt_music_description.Text);
            command.Parameters.AddWithValue("album_name", txt_music_album_name.Text);
            command.Parameters.AddWithValue("awards", "1234567890");

            command.ExecuteNonQuery();
            MessageBox.Show("added successfully!");


        }

        private void music_add_form_Load(object sender, EventArgs e)
        {

            conn1.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Library_Database.mdf;Integrated Security=True";
            conn1.Open();
        }
    }
}
