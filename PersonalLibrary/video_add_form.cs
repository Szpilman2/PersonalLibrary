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
    public partial class video_add_form : Form
    {
        SqlConnection conn3 = new SqlConnection();
        public video_add_form()
        {
            InitializeComponent();
        }

        private void video_add_form_Load(object sender, EventArgs e)
        {
            conn3.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Library_Database.mdf;Integrated Security=True";
            conn3.Open();
        }

        private void btn_add_movie_Click(object sender, EventArgs e)
        {

            string commandString = @"INSERT INTO TBLvideo(video_title,video_genre,video_director,video_year_of_build,video_description,video_status,video_awards) VALUES(@title,@genre,@director, @year, @desc,'FALSE',@awards)";


            SqlCommand command = new SqlCommand(commandString, conn3);
            command.Parameters.AddWithValue("director", txt_video_director.Text);
            command.Parameters.AddWithValue("genre", combox_video.Text);
            command.Parameters.AddWithValue("title", txt_video_name.Text);
            command.Parameters.AddWithValue("desc", txt_video_description.Text);
            command.Parameters.AddWithValue("year", txt_video_publish_year.Text);
            command.Parameters.AddWithValue("awards", "1234567890");

            command.ExecuteNonQuery();
            MessageBox.Show("added successfully!");

        }
    }
}
