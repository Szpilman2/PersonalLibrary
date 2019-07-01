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
    public partial class book_find_form : Form
    {
        SqlConnection conn2 = new SqlConnection();
        public book_find_form()
        {
            InitializeComponent();
        }

        private void book_find_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DatabaseDataSet8.TBLbook' table. You can move, or remove it, as needed.
            this.tBLbookTableAdapter.Fill(this.library_DatabaseDataSet8.TBLbook);
            conn2 = tBLbookTableAdapter.Connection;
            conn2.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ((BindingSource)dataGridView_book_find.DataSource).Filter = string.Format("[{0}] LIKE '%{1}%'", "book_title", textBox1.Text);
        }
    }
}
