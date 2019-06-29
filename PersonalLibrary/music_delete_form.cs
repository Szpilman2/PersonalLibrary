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
    public partial class music_delete_form : Form
    {
        SqlConnection conn1 = new SqlConnection();
        SqlCommand cmd1 = new SqlCommand();
        SqlDataAdapter da1 = new SqlDataAdapter();
        DataSet ds1 = new DataSet();
        public music_delete_form()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void music_delete_form_Load(object sender, EventArgs e)
        {
            //cmd1.CommandText = "select * from TBLMusic";
            //cmd1.Connection = conn1;
            //da1.SelectCommand = cmd1;
            //da1.Fill(ds1, "newtbl");
            //dataGridView1.DataBindings.Clear();
            //dataGridView1.DataBindings.Add("datasource", ds1, "newtbl");
        }
    }
}
