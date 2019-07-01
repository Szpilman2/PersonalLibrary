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
    public partial class video_find_form : Form
    {
        SqlConnection conn2 = new SqlConnection();
        public video_find_form()
        {
            InitializeComponent();
        }

        private void video_find_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DatabaseDataSet11.TBLVideo' table. You can move, or remove it, as needed.
            this.tBLVideoTableAdapter.Fill(this.library_DatabaseDataSet11.TBLVideo);
            conn2 = tBLVideoTableAdapter.Connection;
            conn2.Open();

        }

        private void textBox_find_movie_TextChanged(object sender, EventArgs e)
        {
            ((BindingSource)dataGridView_movie_find.DataSource).Filter = string.Format("[{0}] LIKE '%{1}%'", "video_title", textBox_find_movie.Text);
        }
    }
}
