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
    public partial class music_find_form : Form
    {
        SqlConnection conn2 = new SqlConnection();
        public music_find_form()
        {
            InitializeComponent();
        }

        private void music_find_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DatabaseDataSet12.TBLMusic' table. You can move, or remove it, as needed.
            this.tBLMusicTableAdapter.Fill(this.library_DatabaseDataSet12.TBLMusic);
            conn2 = tBLMusicTableAdapter.Connection;
            conn2.Open();

        }

        private void txtbox_find_music_TextChanged(object sender, EventArgs e)
        {
            ((BindingSource)dataGridView_music_find.DataSource).Filter = string.Format("[{0}] LIKE '%{1}%'", "music_title", txtbox_find_music.Text);
        }
    }
}
