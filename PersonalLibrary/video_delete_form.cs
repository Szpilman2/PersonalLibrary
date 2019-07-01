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
    public partial class video_delete_form : Form
    {
        SqlConnection conn2 = new SqlConnection();
        public video_delete_form()
        {
            InitializeComponent();
        }

        private void video_delete_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DatabaseDataSet13.TBLVideo' table. You can move, or remove it, as needed.
            this.tBLVideoTableAdapter.Fill(this.library_DatabaseDataSet13.TBLVideo);
            conn2 = tBLVideoTableAdapter.Connection;
            conn2.Open();

        }

        private void btn_bd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Not selected anything!");
                return;
            }
            Int32 id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);


            SqlCommand command = new SqlCommand("DELETE FROM [dbo].[TBLbook] WHERE id = @BookID");
            command.Connection = conn2;
            command.Parameters.AddWithValue("BookID", id);

            command.ExecuteNonQuery();
            dataGridView1.Update();
            MessageBox.Show("Removed Successfully!");
        }
    }
}
