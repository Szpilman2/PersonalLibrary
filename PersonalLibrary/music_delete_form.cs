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
            // TODO: This line of code loads data into the 'library_DatabaseDataSet2.TBLMusic' table. You can move, or remove it, as needed.
            this.tBLMusicTableAdapter2.Fill(this.library_DatabaseDataSet2.TBLMusic);
            conn1 = tBLMusicTableAdapter2.Connection;
            conn1.Open();


            //cmd1.CommandText = "select * from TBLMusic";
            //cmd1.Connection = conn1;
            //da1.SelectCommand = cmd1;
            //da1.Fill(ds1, "newtbl");
            //dataGridView1.DataBindings.Clear();
            //dataGridView1.DataBindings.Add("datasource", ds1, "newtbl");
        }

        private void btn_md_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Not selected anything!");
                return;
            }
            Int32 id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

            
            SqlCommand command = new SqlCommand("DELETE FROM [dbo].[TBLMusic] WHERE id = @MusicID");
            command.Connection = conn1;
            command.Parameters.AddWithValue("MusicID", id);
            
            command.ExecuteNonQuery();
            dataGridView1.Update();
            MessageBox.Show("Removed Successfully!");

        }
    }
}
