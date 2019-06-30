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
            /*
            conn1.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Library_Database.mdf;Integrated Security=True";
            conn1.Open();
            SqlCommand command = new SqlCommand("INSERT INTO TBLMusic VALUES(@MusicID)");
            command.Connection = conn1;
            command.Parameters.AddWithValue("MusicID", id);
            command.ExecuteNonQuery();
            */

        }
    }
}
